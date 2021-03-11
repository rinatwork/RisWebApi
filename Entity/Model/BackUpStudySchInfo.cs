using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class BackUpStudySchInfo
    {
        public int Id { get; set; }
        public Guid BackUpGuid { get; set; }
        public Guid StudyGuid { get; set; }
        public DateTime SchDate { get; set; }
        public Guid SchItemGuid { get; set; }
        public Guid SchTimeGuid { get; set; }
        public int OrderId { get; set; }
        public string Bks1 { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }
        public DateTime? Bkd { get; set; }
        public decimal? Bki { get; set; }
        public bool? Bkb { get; set; }

        public virtual BackUpStudy BackUpGu { get; set; }
    }
}
