using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class StaffPost
    {
        public string StaffId { get; set; }
        public string Name { get; set; }
        public string BelongPost { get; set; }
        public string PostName { get; set; }
        public string ShiftNums { get; set; }
        public string Permission { get; set; }
    }
}
