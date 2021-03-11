using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class Shiftdeptstaff1
    {
        public int ShiftManageId { get; set; }
        public string DeptClassId { get; set; }
        public string StaffId { get; set; }
        public string Author { get; set; }
        public DateTime? ShiftDate { get; set; }
        public string GroupId { get; set; }
        public string Name { get; set; }
        public TimeSpan? StartTime { get; set; }
        public string OverDay { get; set; }
        public TimeSpan? EndTime { get; set; }
        public string NeedStaffNum { get; set; }
        public string BelongPost { get; set; }
        public string Staffname { get; set; }
        public string Permission { get; set; }
    }
}
