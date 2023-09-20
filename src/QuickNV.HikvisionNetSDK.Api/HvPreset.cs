namespace QuickNV.HikvisionNetSDK.Api
{
    /// <summary>
    /// 预置点信息
    /// </summary>
    public class HvPreset
    {
        public HvPreset(int number, string name)
        {
            Number = number;
            Name = name;
        }

        /// <summary>
        /// 预置点编号（从1开始）
        /// </summary>
        public int Number { get; internal set; }

        /// <summary>
        /// 预置点名称
        /// </summary>
        public string Name { get; internal set; }

        /// <summary>
        /// 水平参数：角度
        /// </summary>
        public double PanPos { get; set; }

        /// <summary>
        /// 垂直参数：角度
        /// </summary>
        public double TiltPos { get; set; }

        /// <summary>
        /// 变倍参数：倍数
        /// </summary>
        public double ZoomPos { get; set; }

        /// <summary>
        /// 是否被设置
        /// </summary>
        public bool IsSet => PanPos != 0 && TiltPos != 0;

        public override string ToString()
        {
            return $"[{Number}] {Name} P:{PanPos} T:{TiltPos} Z:{ZoomPos}";
        }
    }
    
    /// <summary>
    /// PTZ位置信息
    /// </summary>
    public class HvPtzPosition
    {
        public HvPtzPosition()
        {
        }

        public HvPtzPosition(double panPos, double tiltPos, double zoomPos)
        {
            PanPos = panPos;
            TiltPos = tiltPos;
            ZoomPos = zoomPos;
        }

        /// <summary>
        /// 水平参数：角度
        /// </summary>
        public double PanPos { get; set; }

        /// <summary>
        /// 垂直参数：角度
        /// </summary>
        public double TiltPos { get; set; }

        /// <summary>
        /// 变倍参数：倍数
        /// </summary>
        public double ZoomPos { get; set; }
    }
}