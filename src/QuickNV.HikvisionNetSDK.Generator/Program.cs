using CHCNetSDK_Splitter;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Text;

namespace HikvisionNetSDK.Generator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // 注册编码提供程序，以支持GBK编码
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            // 读取源文件
            string sourceFile = "CHCNetSDK.cs";
            string code = File.ReadAllText(sourceFile, Encoding.GetEncoding("gb2312"))
                .Replace("CHCNetSDK.", "");

            // 初始化生成器
            CodeGenerator generator = new CodeGenerator();

            // 提取错误代码
            string errorCodesSection = ExtractErrorCodes(code, generator);

            // 删除错误代码部分
            string codeWithoutErrors = RemoveErrorCodes(code);

            // 解析剩余代码
            SyntaxTree tree = CSharpSyntaxTree.ParseText(codeWithoutErrors);
            CompilationUnitSyntax root = tree.GetCompilationUnitRoot();
            var outFolder = "../../../../QuickNV.HikvisionNetSDK";
            Environment.CurrentDirectory = outFolder;
            // 生成代码
            generator.Generate(root);

            // 生成文件
            generator.WriteFiles(".");

            Console.WriteLine("Done");
        }

        /// <summary>
        /// 从代码中提取错误代码部分
        /// </summary>
        private static string ExtractErrorCodes(string code, CodeGenerator generator)
        {
            // 错误代码开始和结束标记
            string errorStartMarker = "/*******************全局错误码 begin**********************/";
            string errorEndMarker = "/*******************全局错误码 end**********************/";

            int startIndex = code.IndexOf(errorStartMarker);
            int endIndex = code.IndexOf(errorEndMarker);

            if (startIndex != -1 && endIndex != -1 && endIndex > startIndex)
            {
                endIndex += errorEndMarker.Length;
                string errorSection = code.Substring(startIndex, endIndex - startIndex);

                // 将错误代码部分转换为临时文件内容，以便使用Roslyn解析
                string tempCode = $@"using System;
namespace Temp
{{
    public class TempClass
    {{
        {errorSection}
    }}
}}";

                // 解析错误代码
                SyntaxTree tempTree = CSharpSyntaxTree.ParseText(tempCode);
                CompilationUnitSyntax tempRoot = tempTree.GetCompilationUnitRoot();

                // 处理错误代码
                ProcessErrorCodes(tempRoot, generator);

                return errorSection;
            }

            return string.Empty;
        }

        /// <summary>
        /// 处理提取出的错误代码
        /// </summary>
        private static void ProcessErrorCodes(CompilationUnitSyntax root, CodeGenerator generator)
        {
            // 遍历命名空间
            foreach (var member in root.Members)
            {
                if (member is NamespaceDeclarationSyntax namespaceDecl)
                {
                    // 遍历命名空间中的类
                    foreach (var namespaceMember in namespaceDecl.Members)
                    {
                        if (namespaceMember is ClassDeclarationSyntax classDecl)
                        {
                            // 遍历类中的成员，只处理常量字段
                            foreach (var classMember in classDecl.Members)
                            {
                                if (classMember is FieldDeclarationSyntax fieldDecl)
                                {
                                    // 检查是否是常量字段
                                    if (fieldDecl.Modifiers.Any(SyntaxKind.ConstKeyword))
                                    {
                                        // 获取字段注释
                                        string fieldComment = generator.GetComment(fieldDecl);

                                        // 生成字段声明
                                        string modifiers = string.Join(" ", fieldDecl.Modifiers);
                                        string fieldType = fieldDecl.Declaration.Type.ToString();

                                        foreach (var variable in fieldDecl.Declaration.Variables)
                                        {
                                            string fieldName = variable.Identifier.Text;
                                            string fieldValue = variable.Initializer?.Value.ToString() ?? "";

                                            // 清理字段值，移除无效字符
                                            fieldValue = fieldValue.Replace(";", "")
                                                                   .Replace("；", "")
                                                                   .Replace("，", ",")
                                                                   .Replace("。", "")
                                                                   .Replace("（", "(")
                                                                   .Replace("）", ")")
                                                                   .Trim();

                                            // 清理注释，移除注释标记和无关文本
                                            string cleanComment = fieldComment.Replace("//", "").Trim();

                                            // 添加到错误列表
                                            generator.AddErrorInfo(new ErrorInfo
                                            {
                                                Name = fieldName,
                                                Value = fieldValue,
                                                Description = cleanComment
                                            });
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 从代码中删除错误代码部分
        /// </summary>
        private static string RemoveErrorCodes(string code)
        {
            string errorStartMarker = "全局错误码 begin";
            string errorEndMarker = "全局错误码 end";

            int startIndex = code.IndexOf(errorStartMarker);
            int endIndex = code.IndexOf(errorEndMarker);

            if (startIndex != -1 && endIndex != -1 && endIndex > startIndex)
            {
                endIndex += errorEndMarker.Length;
                return code.Substring(0, startIndex) + code.Substring(endIndex);
            }

            return code;
        }
    }

    internal class CodeGenerator
    {
        private StringBuilder definesBuilder = new StringBuilder();
        private StringBuilder methodsBuilder = new StringBuilder();
        private StringBuilder errorsBuilder = new StringBuilder();
        private List<ErrorInfo> errorList = new List<ErrorInfo>();
        private List<MethodInfo> methodList = new List<MethodInfo>();
        private static char[] SplitChars = new[] { '\r', '\n' };

        private class MethodInfo
        {
            public MethodDeclarationSyntax MethodDecl { get; set; }
            public string Comment { get; set; }
        }

        /// <summary>
        /// 添加错误信息
        /// </summary>
        public void AddErrorInfo(ErrorInfo errorInfo)
        {
            errorList.Add(errorInfo);
        }

        /// <summary>
        /// 移除 #region 和 #endregion 指令
        /// </summary>
        public class RegionRemover : CSharpSyntaxRewriter
        {
            public override SyntaxTrivia VisitTrivia(SyntaxTrivia trivia)
            {
                // 移除 #region 和 #endregion 指令
                if (trivia.IsKind(SyntaxKind.RegionDirectiveTrivia) ||
                    trivia.IsKind(SyntaxKind.EndRegionDirectiveTrivia))
                {
                    return default; // 返回默认值会移除该 trivia
                }

                return base.VisitTrivia(trivia);
            }
        }

        public void Generate(CompilationUnitSyntax root)
        {
            //移除 #region 和 #endregion 指令
            var remover = new RegionRemover();
            root = (CompilationUnitSyntax)remover.Visit(root);

            // 构建Defines.cs文件头
            definesBuilder.AppendLine("using System;");
            definesBuilder.AppendLine("using System.Runtime.InteropServices;");
            definesBuilder.AppendLine();
            definesBuilder.AppendLine("namespace QuickNV.HikvisionNetSDK");
            definesBuilder.AppendLine("{");
            definesBuilder.AppendLine("    /// <summary>");
            definesBuilder.AppendLine("    /// CHCNetSDK 的摘要说明。");
            definesBuilder.AppendLine("    /// </summary>");
            definesBuilder.AppendLine("    public partial class Defines");
            definesBuilder.AppendLine("    {");
            definesBuilder.AppendLine("        public Defines()");
            definesBuilder.AppendLine("        {");
            definesBuilder.AppendLine("            //");
            definesBuilder.AppendLine("            // TODO: 在此处添加构造函数逻辑");
            definesBuilder.AppendLine("            //");
            definesBuilder.AppendLine("        ");
            definesBuilder.AppendLine("        }");
            definesBuilder.AppendLine();

            // 遍历命名空间
            foreach (var member in root.Members)
            {
                if (member is NamespaceDeclarationSyntax namespaceDecl)
                {
                    // 遍历命名空间中的类
                    foreach (var namespaceMember in namespaceDecl.Members)
                    {
                        if (namespaceMember is ClassDeclarationSyntax classDecl)
                        {
                            // 遍历类中的成员
                            foreach (var classMember in classDecl.Members)
                            {
                                // 处理字段
                                if (classMember is FieldDeclarationSyntax fieldDecl)
                                {
                                    ProcessField(fieldDecl);
                                }
                                // 处理结构体
                                else if (classMember is StructDeclarationSyntax structDecl)
                                {
                                    ProcessStruct(structDecl);
                                }
                                // 处理方法
                                else if (classMember is MethodDeclarationSyntax methodDecl)
                                {
                                    ProcessMethod(methodDecl);
                                }
                                // 处理枚举
                                else if (classMember is EnumDeclarationSyntax enumDecl)
                                {
                                    ProcessEnum(enumDecl);
                                }
                                // 处理委托
                                else if (classMember is DelegateDeclarationSyntax delegateDecl)
                                {
                                    ProcessDelegate(delegateDecl);
                                }
                                else
                                {
                                    Console.WriteLine("Warning: Untranslated type.");
                                }
                            }
                        }
                    }
                }
            }

            // 结束Defines.cs文件
            definesBuilder.AppendLine("    ");
            definesBuilder.AppendLine("    }");
            definesBuilder.AppendLine("}");

            // 生成Errors.cs
            GenerateErrors();

            // 生成Methods.cs
            GenerateMethods();
        }

        private void ProcessField(FieldDeclarationSyntax fieldDecl)
        {
            // 检查是否是常量字段
            if (fieldDecl.Modifiers.Any(SyntaxKind.ConstKeyword))
            {
                // 获取字段注释
                string fieldComment = GetComment(fieldDecl);

                // 转换为标准文档注释
                string docComment = ConvertToDocComment(fieldComment);

                // 生成字段声明
                string modifiers = string.Join(" ", fieldDecl.Modifiers);
                string fieldType = fieldDecl.Declaration.Type.ToString();

                foreach (var variable in fieldDecl.Declaration.Variables)
                {
                    string fieldName = variable.Identifier.Text;
                    string fieldValue = variable.Initializer?.Value.ToString() ?? "";

                    // 清理字段值，移除无效字符
                    fieldValue = fieldValue.Replace(";", "")
                                           .Replace("；", "")
                                           .Replace("，", ",")
                                           .Replace("。", "")
                                           .Replace("（", "(")
                                           .Replace("）", ")")
                                           .Trim();

                    // 写入Defines.cs，确保所有行都有8个空格缩进
                    if (!string.IsNullOrEmpty(docComment))
                    {
                        // 先移除多余的空行，然后添加缩进
                        string[] commentLines = docComment.Split(SplitChars, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string line in commentLines)
                        {
                            definesBuilder.AppendLine($"        {line}");
                        }
                    }
                    definesBuilder.AppendLine($"        {modifiers} {fieldType} {fieldName} = {fieldValue};");
                }
            }
        }

        private void ProcessStruct(StructDeclarationSyntax structDecl)
        {
            // 获取注释并转换为标准文档注释
            string comment = GetComment(structDecl);
            string docComment = ConvertToDocComment(comment);

            // 写入Defines.cs
            definesBuilder.AppendLine();
            if (!string.IsNullOrEmpty(docComment))
            {
                string[] commentLines = docComment.Split(SplitChars, StringSplitOptions.RemoveEmptyEntries);
                foreach (string line in commentLines)
                {
                    definesBuilder.AppendLine($"        {line}");
                }
            }

            // 添加StructLayout属性
            // 从原始结构体中提取StructLayout属性
            foreach (var attributeList in structDecl.AttributeLists)
            {
                definesBuilder.AppendLine($"        {attributeList.ToFullString().Trim()}");
            }
            definesBuilder.AppendLine($"        {structDecl.Modifiers} struct {structDecl.Identifier}");
            definesBuilder.AppendLine("        {");

            // 遍历结构体成员
            foreach (var structMember in structDecl.Members)
            {
                // 只处理字段成员
                if (structMember is FieldDeclarationSyntax fieldDecl)
                {
                    // 获取成员注释并转换为标准文档注释
                    string memberComment = GetComment(fieldDecl);
                    if (memberComment != null)
                        memberComment = memberComment
                            .Replace("<","&lt;")
                            .Replace(">","&gt;")
                            .Replace("&","&amp;");
                    
                    string memberDocComment = ConvertToDocComment(memberComment);
                    if (!string.IsNullOrEmpty(memberDocComment))
                    {
                        // 结构体成员注释：添加12个空格缩进
                        string[] commentLines = memberDocComment.Split(SplitChars, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string line in commentLines)
                        {
                            definesBuilder.AppendLine($"            {line}");
                        }
                    }

                    // 生成字段属性
                    foreach (var attributeList in fieldDecl.AttributeLists)
                    {
                        definesBuilder.AppendLine("            " + attributeList.ToString().Trim());
                    }

                    string fieldType = fieldDecl.Declaration.Type.ToString();
                    string fieldModifiers = string.Join(" ", fieldDecl.Modifiers);

                    // 处理多个变量声明
                    foreach (var variable in fieldDecl.Declaration.Variables)
                    {
                        string fieldName = variable.Identifier.Text;
                        if (!string.IsNullOrEmpty(fieldModifiers))
                        {
                            definesBuilder.AppendLine($"            {fieldModifiers} {fieldType} {fieldName};");
                        }
                        else
                        {
                            definesBuilder.AppendLine($"            {fieldType} {fieldName};");
                        }
                    }
                }
                else if (structMember is MethodDeclarationSyntax methodDecl)
                {
                    definesBuilder.AppendLine(methodDecl.ToFullString());
                }
                else if (structMember is StructDeclarationSyntax subStructDecl)
                {
                    //ProcessStruct(subStructDecl);
                    definesBuilder.AppendLine(subStructDecl.ToFullString());
                }
                else
                {
                    definesBuilder.AppendLine(structMember.ToFullString());
                    Console.WriteLine("Warning: Untranslated type.");
                }
            }

            definesBuilder.AppendLine("        }");
        }

        private void ProcessMethod(MethodDeclarationSyntax methodDecl)
        {
            // 检查是否是DllImport方法
            bool isDllImport = false;
            foreach (var attributeList in methodDecl.AttributeLists)
            {
                foreach (var attribute in attributeList.Attributes)
                {
                    // 检查是否是DllImport属性，包括DllImport和DllImportAttribute两种形式
                    string attributeName = attribute.Name.ToString();
                    if (attributeName == "DllImport" ||
                        attributeName == "DllImportAttribute" ||
                        attributeName == "System.Runtime.InteropServices.DllImport" ||
                        attributeName == "System.Runtime.InteropServices.DllImportAttribute")
                    {
                        isDllImport = true;
                        break;
                    }
                }
                if (isDllImport)
                {
                    break;
                }
            }

            if (isDllImport)
            {
                // 获取方法注释
                string comment = GetComment(methodDecl);

                // 存储方法声明和注释
                MethodInfo methodInfo = new MethodInfo
                {
                    MethodDecl = methodDecl,
                    Comment = comment
                };
                methodList.Add(methodInfo);

                // 调试信息
                Console.WriteLine($"Found method: {methodDecl.Identifier.Text}");
                Console.WriteLine($"  Comment: {comment}");
            }
        }

        private void ProcessDelegate(DelegateDeclarationSyntax delegateDecl)
        {
            // 获取注释并转换为标准文档注释
            string comment = GetComment(delegateDecl);
            string docComment = ConvertToDocComment(comment);

            // 生成委托声明
            string returnType = delegateDecl.ReturnType.ToString();
            string delegateName = delegateDecl.Identifier.Text;
            string modifiers = string.Join(" ", delegateDecl.Modifiers);

            // 处理参数列表
            string parameters = string.Join(", ", delegateDecl.ParameterList.Parameters.Select(p => p.ToFullString().Trim()));

            // 写入Defines.cs
            definesBuilder.AppendLine();
            if (!string.IsNullOrEmpty(docComment))
            {
                string[] commentLines = docComment.Split(SplitChars, StringSplitOptions.RemoveEmptyEntries);
                foreach (string line in commentLines)
                {
                    definesBuilder.AppendLine($"        {line}");
                }
            }
            definesBuilder.AppendLine($"        {modifiers} delegate {returnType} {delegateName}({parameters});");
        }

        private void ProcessEnum(EnumDeclarationSyntax enumDecl)
        {
            // 获取注释并转换为标准文档注释
            string comment = GetComment(enumDecl);
            string docComment = ConvertToDocComment(comment);

            // 写入Defines.cs
            definesBuilder.AppendLine();
            if (!string.IsNullOrEmpty(docComment))
            {
                string[] commentLines = docComment.Split(SplitChars, StringSplitOptions.RemoveEmptyEntries);
                foreach (string line in commentLines)
                {
                    definesBuilder.AppendLine($"        {line}");
                }
            }
            string enumDefinition;
            if (enumDecl.BaseList != null && enumDecl.BaseList.Types.Count > 0)
            {
                // 枚举有基类型，如 : uint
                enumDefinition = $"        {enumDecl.Modifiers} enum {enumDecl.Identifier} {enumDecl.BaseList.ToString()}";
            }
            else
            {
                // 枚举没有基类型
                enumDefinition = $"        {enumDecl.Modifiers} enum {enumDecl.Identifier}";
            }
            definesBuilder.AppendLine(enumDefinition);
            definesBuilder.AppendLine("        {");

            var fullcode = enumDecl.Members.ToFullString().Split(SplitChars, StringSplitOptions.RemoveEmptyEntries);
            // 遍历枚举成员
            for (int i = 0; i < enumDecl.Members.Count; i++)
            {
                var enumMember = enumDecl.Members[i];

                // 获取成员注释
                string memberComment = GetComment(enumMember);
                if (string.IsNullOrWhiteSpace(memberComment))
                {
                    var line = fullcode.FirstOrDefault(o => o.Contains(enumMember.Identifier.Text));
                    if (!string.IsNullOrEmpty(line))
                    {
                        var index = line.IndexOf("//");
                        if (index > 0)
                            memberComment = line.Substring(index + 2).Trim();
                        else if ((index = line.IndexOf("/*")) > 0)
                        {
                            memberComment = line.Substring(index + 2).Trim();
                            index = memberComment.IndexOf("*/");
                            if (index > 0)
                                memberComment = memberComment[..index].Trim();
                        }
                    }
                }

                // 转换为标准文档注释
                string memberDocComment = ConvertToDocComment(memberComment);
                if (!string.IsNullOrEmpty(memberDocComment))
                {
                    // 枚举成员注释：添加12个空格缩进
                    string[] commentLines = memberDocComment.Split(SplitChars, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string line in commentLines)
                    {
                        definesBuilder.AppendLine($"            {line}");
                    }
                }

                string enumMemberStr;
                if (enumMember.EqualsValue != null)
                {
                    // 枚举成员有显式赋值
                    enumMemberStr = $"            {enumMember.Identifier} = {enumMember.EqualsValue.Value}";
                }
                else
                {
                    // 枚举成员没有显式赋值，只输出成员名称
                    enumMemberStr = $"            {enumMember.Identifier}";
                }
                if (i < enumDecl.Members.Count - 1)
                {
                    enumMemberStr += ",";
                }
                definesBuilder.AppendLine(enumMemberStr);
            }

            definesBuilder.AppendLine("        }");
        }

        private void GenerateErrors()
        {
            errorsBuilder.AppendLine("using System.ComponentModel;");
            errorsBuilder.AppendLine();
            errorsBuilder.AppendLine("namespace QuickNV.HikvisionNetSDK");
            errorsBuilder.AppendLine("{");
            errorsBuilder.AppendLine("    /// <summary>");
            errorsBuilder.AppendLine("    /// 海康SDK错误代码枚举");
            errorsBuilder.AppendLine("    /// </summary>");
            errorsBuilder.AppendLine("    public enum Errors");
            errorsBuilder.AppendLine("    {");

            for (int i = 0; i < errorList.Count; i++)
            {
                var error = errorList[i];
                // 添加XML文档注释
                if (!string.IsNullOrEmpty(error.Description))
                {
                    errorsBuilder.AppendLine("        /// <summary>");
                    errorsBuilder.AppendLine($"        /// {error.Description}");
                    errorsBuilder.AppendLine("        /// </summary>");
                }
                errorsBuilder.AppendLine($"        [Description(\"{error.Description}\")]");
                errorsBuilder.Append($"        {error.Name} = {error.Value}");
                if (i < errorList.Count - 1)
                {
                    errorsBuilder.AppendLine(",");
                }
                else
                {
                    errorsBuilder.AppendLine();
                }
            }

            errorsBuilder.AppendLine("    }");
            errorsBuilder.AppendLine("}");
        }

        private void GenerateMethods()
        {
            // 生成Methods_Win.cs
            GeneratePlatformMethods("Methods_Win", "HCNetSDK.dll");

            // 生成Methods_Linux.cs
            GeneratePlatformMethods("Methods_Linux", "hcnetsdk.so");

            // 生成Methods.cs
            GenerateCrossPlatformMethods();
        }

        private void GeneratePlatformMethods(string className, string dllPath)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Runtime.InteropServices;");
            sb.AppendLine("using static QuickNV.HikvisionNetSDK.Defines;");
            sb.AppendLine();
            sb.AppendLine("namespace QuickNV.HikvisionNetSDK");
            sb.AppendLine("{");
            sb.AppendLine($"    internal class {className}");
            sb.AppendLine("    {");
            sb.AppendLine($"        public const string DllPath = \"{dllPath}\";");
            sb.AppendLine();

            // 调试信息
            Console.WriteLine($"Generating {className}.cs with {methodList.Count} methods");

            int methodCount = 0;
            foreach (var methodInfo in methodList)
            {
                // 直接使用存储的MethodDecl对象
                MethodDeclarationSyntax methodDecl = methodInfo.MethodDecl;

                if (methodDecl != null)
                {
                    try
                    {
                        // 调试信息
                        Console.WriteLine($"Processing method: {methodDecl.Identifier.Text}");

                        // 获取方法注释
                        string methodComment = methodInfo.Comment;
                        string docComment = ConvertToDocComment(methodComment);
                        if (!string.IsNullOrEmpty(docComment))
                        {
                            // 平台特定方法：添加8个空格的缩进（与方法声明一致）
                            string[] commentLines = docComment.Split(SplitChars, StringSplitOptions.RemoveEmptyEntries);
                            foreach (string line in commentLines)
                            {
                                sb.AppendLine($"        {line}");
                            }
                        }
                        sb.AppendLine("        [DllImport(DllPath)]");
                        // 生成方法声明
                        string modifiers = string.Join(" ", methodDecl.Modifiers);
                        string returnType = methodDecl.ReturnType.ToString();
                        string methodName = methodDecl.Identifier.Text;

                        // 生成参数列表
                        // 处理参数列表
                        string parameters = string.Join(", ", methodDecl.ParameterList.Parameters.Select(p => p.ToFullString().Trim()));

                        // 写入方法
                        sb.AppendLine($"        {modifiers} {returnType} {methodName}({parameters});");
                        sb.AppendLine();

                        methodCount++;
                        // 调试信息
                        Console.WriteLine($"  Method {methodCount} written: {methodName}");
                    }
                    catch (Exception ex)
                    {
                        // 调试信息
                        Console.WriteLine($"  Error processing method {methodDecl.Identifier.Text}: {ex.Message}");
                    }
                }
            }

            // 关闭类和命名空间
            sb.AppendLine("    }");
            sb.AppendLine("}");

            File.WriteAllText($"{className}.cs", sb.ToString());

            // 调试信息
            Console.WriteLine($"Generated {className}.cs successfully");
            Console.WriteLine($"  Methods written: {methodCount}");
        }

        private void GenerateCrossPlatformMethods()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("using System.Runtime.InteropServices;");
            sb.AppendLine("using System.Text;");
            sb.AppendLine("using static QuickNV.HikvisionNetSDK.Defines;");
            sb.AppendLine();
            sb.AppendLine("namespace QuickNV.HikvisionNetSDK");
            sb.AppendLine("{");
            sb.AppendLine("    public class Methods");
            sb.AppendLine("    {");
            sb.AppendLine("        private static bool IsWindows = Environment.OSVersion.Platform == PlatformID.Win32NT;\n\n" +
                "        public static int Invoke(int result)\n" +
                "        {\n            if (result < 0)\n" +
                "            {\n                uint lastErrorCode = NET_DVR_GetLastError();\n" +
                "                throw new HikvisionException(lastErrorCode);\n" +
                "            }\n            return result;\n" +
                "        }\n" +
                "\n" +
                "        public static bool Invoke(bool result)\n" +
                "        {\n            if (!result)\n" +
                "            {\n                uint lastErrorCode = NET_DVR_GetLastError();\n" +
                "                throw new HikvisionException(lastErrorCode);\n" +
                "            }\n            return result;\n" +
                "        }");
            sb.AppendLine();

            // 生成方法包装
            foreach (var methodInfo in methodList)
            {
                // 直接使用存储的MethodDecl对象
                MethodDeclarationSyntax methodDecl = methodInfo.MethodDecl;
                if (methodDecl != null)
                {
                    GenerateMethodWrapper(sb, methodDecl);
                }
            }

            sb.AppendLine("    }");
            sb.AppendLine("}");

            File.WriteAllText("Methods.cs", sb.ToString());
        }

        private void GenerateMethodWrapper(StringBuilder sb, MethodDeclarationSyntax methodDecl)
        {
            // 获取方法信息
            var methodInfo = methodList.FirstOrDefault(m => m.MethodDecl == methodDecl);
            if (methodInfo != null)
            {
                // 转换为标准文档注释
                string docComment = ConvertToDocComment(methodInfo.Comment);
                if (!string.IsNullOrEmpty(docComment))
                {
                    // 跨平台方法：添加8个空格的缩进
                    string[] commentLines = docComment.Split(SplitChars, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string line in commentLines)
                    {
                        sb.AppendLine($"        {line}");
                    }
                }
            }

            // 方法签名
            string returnType = methodDecl.ReturnType.ToString();
            string methodName = methodDecl.Identifier.Text;

            // 生成参数列表
            List<string> parameters = new List<string>();
            List<string> paramCalls = new List<string>();
            foreach (var param in methodDecl.ParameterList.Parameters)
            {
                string paramType = param.Type.ToString();
                string paramName = param.Identifier.Text;
                string paramModifiers = string.Join(" ", param.Modifiers);

                // 生成参数声明
                string paramFullText = param.ToFullString().Trim();
                parameters.Add(paramFullText);
                // 生成参数调用，保留ref/out修饰符
                var callModifiers = param.Modifiers.ToString().Trim();

                if (!string.IsNullOrEmpty(callModifiers))
                {
                    paramCalls.Add($"{callModifiers} {paramName}");
                }
                else
                {
                    paramCalls.Add(paramName);
                }
            }

            // 生成方法声明
            sb.AppendLine($"        public static {returnType} {methodName}({string.Join(", ", parameters)})");
            sb.AppendLine("        {");

            // 生成方法体
            string returnStr = returnType == "void" ? "" : "return ";
            sb.AppendLine("            if (IsWindows)");
            sb.AppendLine($"                {returnStr}Methods_Win.{methodName}({string.Join(", ", paramCalls)});");
            sb.AppendLine("            else");
            sb.AppendLine($"                {returnStr}Methods_Linux.{methodName}({string.Join(", ", paramCalls)});");
            sb.AppendLine("        }");
            sb.AppendLine();
        }

        /// <summary>
        /// 从语法节点中提取注释
        /// </summary>
        /// <param name="node">语法节点</param>
        /// <returns>提取的注释内容</returns>
        public string GetComment(SyntaxNode node)
        {
            // 使用HashSet来避免重复注释行
            HashSet<string> commentSet = new HashSet<string>();
            bool hasLeadingComments = false;

            // 处理前置注释（优先使用前置注释）
            var leadingTrivia = node.GetLeadingTrivia();
            foreach (var trivia in leadingTrivia)
            {
                if (trivia.IsKind(SyntaxKind.SingleLineCommentTrivia))
                {
                    // 单行注释
                    string comment = trivia.ToString().TrimStart('/').Trim();
                    // 排除全局错误码标记行
                    if (!string.IsNullOrEmpty(comment) && !comment.Contains("全局错误码") && !comment.Contains("NET_DVR_SUPPORT"))
                    {
                        commentSet.Add(comment);
                        hasLeadingComments = true;
                    }
                }
                else if (trivia.IsKind(SyntaxKind.MultiLineCommentTrivia))
                {
                    // 多行注释
                    string comment = trivia.ToString();

                    // 移除开头的/*和结尾的*/
                    comment = comment.Substring(2, comment.Length - 4);

                    // 按行分割
                    string[] lines = comment.Split(SplitChars, StringSplitOptions.RemoveEmptyEntries);

                    // 处理每行，移除开头的*或*
                    for (int i = 0; i < lines.Length; i++)
                    {
                        string line = lines[i].Trim();
                        if (line.StartsWith("*"))
                        {
                            line = line.Substring(1).Trim();
                        }
                        // 排除全局错误码标记行
                        if (!string.IsNullOrEmpty(line) && !line.Contains("全局错误码") && !line.Contains("NET_DVR_SUPPORT"))
                        {
                            commentSet.Add(line);
                            hasLeadingComments = true;
                        }
                    }
                }
                else if (trivia.IsKind(SyntaxKind.SingleLineDocumentationCommentTrivia))
                {
                    // 文档注释
                    string comment = trivia.ToString().Trim();
                    if (!string.IsNullOrEmpty(comment))
                    {
                        commentSet.Add(comment);
                        hasLeadingComments = true;
                    }
                }
            }

            // 如果没有前置注释，再处理后置注释
            if (!hasLeadingComments)
            {
                var trailingTrivia = node.GetTrailingTrivia();
                foreach (var trivia in trailingTrivia)
                {
                    if (trivia.IsKind(SyntaxKind.SingleLineCommentTrivia))
                    {
                        string comment = trivia.ToString().TrimStart('/').Trim();
                        // 排除全局错误码标记行
                        if (!string.IsNullOrEmpty(comment) && !comment.Contains("全局错误码") && !comment.Contains("NET_DVR_SUPPORT"))
                        {
                            commentSet.Add(comment);
                        }
                    }
                }
            }

            // 对于枚举成员，只在没有前置注释的情况下才处理其他注释
            if (node is EnumMemberDeclarationSyntax enumMember && !hasLeadingComments)
            {
                if (enumMember.EqualsValue != null)
                {
                    // 处理等号后面的注释
                    var equalsTrailingTrivia = enumMember.EqualsValue.GetTrailingTrivia();
                    foreach (var trivia in equalsTrailingTrivia)
                    {
                        if (trivia.IsKind(SyntaxKind.SingleLineCommentTrivia) || trivia.IsKind(SyntaxKind.MultiLineCommentTrivia))
                        {
                            string comment = trivia.ToString();
                            if (trivia.IsKind(SyntaxKind.SingleLineCommentTrivia))
                            {
                                comment = comment.TrimStart('/').Trim();
                            }
                            else if (trivia.IsKind(SyntaxKind.MultiLineCommentTrivia))
                            {
                                // 移除开头的/*和结尾的*/
                                comment = comment.Substring(2, comment.Length - 4).Trim();
                            }
                            // 排除全局错误码标记行
                            if (!string.IsNullOrEmpty(comment) && !comment.Contains("全局错误码") && !comment.Contains("NET_DVR_SUPPORT"))
                            {
                                commentSet.Add(comment);
                            }
                        }
                    }
                }

                // 处理枚举成员名称后面的注释（如果有的话）
                var identifierTrailingTrivia = enumMember.Identifier.TrailingTrivia;
                foreach (var trivia in identifierTrailingTrivia)
                {
                    if (trivia.IsKind(SyntaxKind.SingleLineCommentTrivia) || trivia.IsKind(SyntaxKind.MultiLineCommentTrivia))
                    {
                        string comment = trivia.ToString();
                        if (trivia.IsKind(SyntaxKind.SingleLineCommentTrivia))
                        {
                            comment = comment.TrimStart('/').Trim();
                        }
                        else if (trivia.IsKind(SyntaxKind.MultiLineCommentTrivia))
                        {
                            // 移除开头的/*和结尾的*/
                            comment = comment.Substring(2, comment.Length - 4).Trim();
                        }
                        // 排除全局错误码标记行
                        if (!string.IsNullOrEmpty(comment) && !comment.Contains("全局错误码") && !comment.Contains("NET_DVR_SUPPORT"))
                        {
                            commentSet.Add(comment);
                        }
                    }
                }
            }
            // 对于字段声明，只在没有前置注释的情况下才处理行尾注释
            else if (node is FieldDeclarationSyntax fieldDecl && !hasLeadingComments)
            {
                // 处理每个变量声明的注释
                foreach (var variable in fieldDecl.Declaration.Variables)
                {
                    // 处理变量名后面的注释
                    var identifierTrailingTrivia = variable.Identifier.TrailingTrivia;
                    foreach (var trivia in identifierTrailingTrivia)
                    {
                        if (trivia.IsKind(SyntaxKind.SingleLineCommentTrivia) || trivia.IsKind(SyntaxKind.MultiLineCommentTrivia))
                        {
                            string comment = trivia.ToString();
                            if (trivia.IsKind(SyntaxKind.SingleLineCommentTrivia))
                            {
                                comment = comment.TrimStart('/').Trim();
                            }
                            else if (trivia.IsKind(SyntaxKind.MultiLineCommentTrivia))
                            {
                                // 移除开头的/*和结尾的*/
                                comment = comment.Substring(2, comment.Length - 4).Trim();
                            }
                            // 排除全局错误码标记行
                            if (!string.IsNullOrEmpty(comment) && !comment.Contains("全局错误码") && !comment.Contains("NET_DVR_SUPPORT"))
                            {
                                commentSet.Add(comment);
                            }
                        }
                    }

                    // 处理等号后面的注释（如果有的话）
                    if (variable.Initializer != null)
                    {
                        var equalsTrailingTrivia = variable.Initializer.EqualsToken.TrailingTrivia;
                        foreach (var trivia in equalsTrailingTrivia)
                        {
                            if (trivia.IsKind(SyntaxKind.SingleLineCommentTrivia) || trivia.IsKind(SyntaxKind.MultiLineCommentTrivia))
                            {
                                string comment = trivia.ToString();
                                if (trivia.IsKind(SyntaxKind.SingleLineCommentTrivia))
                                {
                                    comment = comment.TrimStart('/').Trim();
                                }
                                else if (trivia.IsKind(SyntaxKind.MultiLineCommentTrivia))
                                {
                                    // 移除开头的/*和结尾的*/
                                    comment = comment.Substring(2, comment.Length - 4).Trim();
                                }
                                // 排除全局错误码标记行
                                if (!string.IsNullOrEmpty(comment) && !comment.Contains("全局错误码") && !comment.Contains("NET_DVR_SUPPORT"))
                                {
                                    commentSet.Add(comment);
                                }
                            }
                        }

                        // 处理初始化器后面的注释
                        var initializerTrailingTrivia = variable.Initializer.GetTrailingTrivia();
                        foreach (var trivia in initializerTrailingTrivia)
                        {
                            if (trivia.IsKind(SyntaxKind.SingleLineCommentTrivia) || trivia.IsKind(SyntaxKind.MultiLineCommentTrivia))
                            {
                                string comment = trivia.ToString();
                                if (trivia.IsKind(SyntaxKind.SingleLineCommentTrivia))
                                {
                                    comment = comment.TrimStart('/').Trim();
                                }
                                else if (trivia.IsKind(SyntaxKind.MultiLineCommentTrivia))
                                {
                                    // 移除开头的/*和结尾的*/
                                    comment = comment.Substring(2, comment.Length - 4).Trim();
                                }
                                // 排除全局错误码标记行
                                if (!string.IsNullOrEmpty(comment) && !comment.Contains("全局错误码") && !comment.Contains("NET_DVR_SUPPORT"))
                                {
                                    commentSet.Add(comment);
                                }
                            }
                        }
                    }
                }

                // 处理字段声明语句的行尾注释
                var fieldTrailingTrivia = fieldDecl.GetTrailingTrivia();
                foreach (var trivia in fieldTrailingTrivia)
                {
                    if (trivia.IsKind(SyntaxKind.SingleLineCommentTrivia) || trivia.IsKind(SyntaxKind.MultiLineCommentTrivia))
                    {
                        string comment = trivia.ToString();
                        if (trivia.IsKind(SyntaxKind.SingleLineCommentTrivia))
                        {
                            comment = comment.TrimStart('/').Trim();
                        }
                        else if (trivia.IsKind(SyntaxKind.MultiLineCommentTrivia))
                        {
                            // 移除开头的/*和结尾的*/
                            comment = comment.Substring(2, comment.Length - 4).Trim();
                        }
                        // 排除全局错误码标记行
                        if (!string.IsNullOrEmpty(comment) && !comment.Contains("全局错误码") && !comment.Contains("NET_DVR_SUPPORT"))
                        {
                            commentSet.Add(comment);
                        }
                    }
                }
            }

            // 将HashSet转换为List并连接成字符串返回
            return string.Join("\n", commentSet.ToList());
        }

        /// <summary>
        /// 将注释转换为dotnet标准文档注释
        /// </summary>
        /// <param name="comment">原始注释</param>
        /// <returns>转换后的文档注释</returns>
        private string ConvertToDocComment(string comment)
        {
            if (string.IsNullOrEmpty(comment))
            {
                return string.Empty;
            }

            // 如果已经是文档注释，直接返回
            if (comment.StartsWith("///"))
            {
                return comment;
            }

            // 转换为文档注释，不添加固定缩进，由调用方根据上下文添加
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("/// <summary>");

            // 处理多行注释
            string[] lines = comment.Split(SplitChars, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                string trimmedLine = line.Trim();
                if (!string.IsNullOrEmpty(trimmedLine))
                {
                    sb.AppendLine($"/// {trimmedLine}");
                }
                else
                {
                    // 保留空行，但不添加内容
                    sb.AppendLine("///");
                }
            }

            sb.AppendLine("/// </summary>");

            return sb.ToString();
        }

        public void WriteFiles(string outputDir)
        {
            // 确保输出目录存在
            Directory.CreateDirectory(outputDir);

            // 写入Defines.cs
            string definesContent = definesBuilder.ToString();
            File.WriteAllText(Path.Combine(outputDir, "Defines.cs"), definesContent);

            // 写入Errors.cs
            string errorsContent = errorsBuilder.ToString();
            File.WriteAllText(Path.Combine(outputDir, "Errors.cs"), errorsContent);
        }
    }
}