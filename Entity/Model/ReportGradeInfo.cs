using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class ReportGradeInfo
    {
        public int Id { get; set; }
        public Guid ReportGuid { get; set; }
        public int? ReportGrade { get; set; }
        public string ReportGradeNote { get; set; }
        public Guid? ReportGradeOwnerGuid { get; set; }
        public DateTime? ReportGradeDate { get; set; }
        public string Bks1 { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }
        public DateTime? Bkd { get; set; }
        public decimal? Bki { get; set; }
        public bool? Bkb { get; set; }
        public int VersionId { get; set; }

        public virtual User ReportGradeOwnerGu { get; set; }
        public virtual Report ReportGu { get; set; }
    }
}
