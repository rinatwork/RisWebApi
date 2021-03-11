using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class MenuItem
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Link { get; set; }
        public int OrderCode { get; set; }
        public Guid? ParentGuid { get; set; }
        public string Bks1 { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }
        public DateTime? Bkd { get; set; }
        public decimal? Bki { get; set; }
        public bool? Bkb { get; set; }
    }
}
