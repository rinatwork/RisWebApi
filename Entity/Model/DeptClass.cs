using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class DeptClass
    {
        public int AutoId { get; set; }
        public int DeptClassId { get; set; }
        public string Name { get; set; }
        public string DeptCode { get; set; }
        public DateTime? StartTime { get; set; }
        public string OverDay { get; set; }
        public DateTime? EndTime { get; set; }
        public string NeedStaffNum { get; set; }
        public string BelongPost { get; set; }
        public string Author { get; set; }
        public string Remark { get; set; }
        public bool? Available { get; set; }
        public string ModType { get; set; }
        public string KeyWords { get; set; }
        public string PostRules { get; set; }
    }
}
