using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class ShiftDate
    {
        public int AutoId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string GroupId { get; set; }
        public string ShiftDate1 { get; set; }
        public string AutorId { get; set; }
        public string AuthorName { get; set; }
        public string OperatoType { get; set; }
        public string ShiftEndDate { get; set; }
        public string BelongPost { get; set; }
    }
}
