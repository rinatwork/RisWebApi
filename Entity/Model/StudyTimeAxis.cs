using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class StudyTimeAxis
    {
        public int Id { get; set; }
        public Guid StudyGuid { get; set; }
        public string ActionName { get; set; }
        public DateTime ActionTime { get; set; }
        public Guid OwnerGuid { get; set; }
        public string Note { get; set; }
        public string Bks1 { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }
        public DateTime? Bkd { get; set; }
        public decimal? Bki { get; set; }
        public bool? Bkb { get; set; }

        public virtual User OwnerGu { get; set; }
        public virtual Study StudyGu { get; set; }
    }
}
