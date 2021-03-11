using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class Template
    {
        public Guid Guid { get; set; }
        public Guid ItemTypeGuid { get; set; }
        public Guid ModeTypeGuid { get; set; }
        public string Name { get; set; }
        public string Py { get; set; }
        public string Method { get; set; }
        public string Description { get; set; }
        public string Diagnosis { get; set; }
        public string Note { get; set; }
        public int? Qualitative { get; set; }
        public string PositiveDesc { get; set; }
        public Guid? OwnerGuid { get; set; }
        public bool IsPublic { get; set; }
        public int OrderId { get; set; }
        public string Bks1 { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }
        public DateTime? Bkd { get; set; }
        public decimal? Bki { get; set; }
        public bool? Bkb { get; set; }
    }
}
