using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class StudySchInfo
    {
        public int Id { get; set; }
        public Guid StudyGuid { get; set; }
        public string SchDate { get; set; }
        public Guid SchItemGuid { get; set; }
        public Guid SchTimeGuid { get; set; }
        public int? OrderId { get; set; }
        public string Bks1 { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }
        public DateTime? Bkd { get; set; }
        public decimal? Bki { get; set; }
        public bool? Bkb { get; set; }
        public string Date { get; set; }
        public long? Sequence { get; set; }
        public int? Slot { get; set; }
        public string SlotTime { get; set; }
        public string Source { get; set; }

        public virtual ArrangeTime SchTimeGu { get; set; }
        public virtual Study StudyGu { get; set; }
    }
}
