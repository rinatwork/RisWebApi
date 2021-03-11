using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class StudyItemIndex
    {
        public int Id { get; set; }
        public Guid StudyGuid { get; set; }
        public Guid ItemTypeGuid { get; set; }
        public Guid ItemGuid { get; set; }
        public string ItemName { get; set; }
        public string Bks1 { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }
        public DateTime? Bkd { get; set; }
        public decimal? Bki { get; set; }
        public bool? Bkb { get; set; }
        public int VersionId { get; set; }

        public virtual Item ItemGu { get; set; }
        public virtual ItemType ItemTypeGu { get; set; }
        public virtual Study StudyGu { get; set; }
    }
}
