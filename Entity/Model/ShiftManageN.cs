using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class ShiftManageN
    {
        public int AutoId { get; set; }
        public int ShiftManageId { get; set; }
        public string ShiftManageName { get; set; }
        public string DeptClassId { get; set; }
        public string ShiftDate { get; set; }
        public string SatffId { get; set; }
        public string AuthorId { get; set; }
    }
}
