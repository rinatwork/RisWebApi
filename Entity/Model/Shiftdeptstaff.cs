using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class Shiftdeptstaff
    {
        public string Name { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public string NeedStaffNum { get; set; }
        public string BelongPost { get; set; }
        public string DeptCode { get; set; }
        public string DeptClassId { get; set; }
        public string StaffId { get; set; }
        public string StaffNames { get; set; }
        public string EffectStartTime { get; set; }
        public DateTime? ShiftDate { get; set; }
        public string GroupId { get; set; }
    }
}
