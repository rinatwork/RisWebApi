using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class YdPac
    {
        public Guid 病人编号 { get; set; }
        public string 影像号 { get; set; }
        public string 影像所见 { get; set; }
        public string 建议 { get; set; }
        public string 检查项目 { get; set; }
        public string 检查日期 { get; set; }
        public string 报告医生 { get; set; }
    }
}
