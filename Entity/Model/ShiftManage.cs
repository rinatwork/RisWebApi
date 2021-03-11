using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class ShiftManage
    {
        public int AutoId { get; set; }
        public int ShiftManageId { get; set; }
        public string ShiftManageName { get; set; }
        public string DeptClassId { get; set; }
        public string StaffId { get; set; }
        public string StaffNames { get; set; }
        public string Author { get; set; }
        public DateTime? ShiftDate { get; set; }
        public string GroupId { get; set; }
        public string EffectEndTime { get; set; }
        public string EffectStartTime { get; set; }
        public string Permission { get; set; }
    }
}
