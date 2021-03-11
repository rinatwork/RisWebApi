using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class Report
    {
        public Report()
        {
            InverseRelatedReport = new HashSet<Report>();
            ReportGradeInfos = new HashSet<ReportGradeInfo>();
            Sections = new HashSet<Section>();
        }

        public Guid Guid { get; set; }
        public Guid StudyGuid { get; set; }
        public bool DraftTag { get; set; }
        public int Type { get; set; }
        public DateTime WriteTime { get; set; }
        public Guid WriteOwnerGuid { get; set; }
        public string WriteOwnerName { get; set; }
        public DateTime? CheckTime { get; set; }
        public Guid? CheckOwnerGuid { get; set; }
        public string CheckOwnerName { get; set; }
        public Guid? RelatedReportId { get; set; }
        public int? Qualitative { get; set; }
        public string PositiveDesc { get; set; }
        public Guid? StyleGuid { get; set; }
        public int OrderId { get; set; }
        public string Bks1 { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }
        public DateTime? Bkd { get; set; }
        public decimal? Bki { get; set; }
        public bool? Bkb { get; set; }
        public int VersionId { get; set; }
        public string ReportImages { get; set; }
        public string ReportPdfPath { get; set; }

        public virtual User CheckOwnerGu { get; set; }
        public virtual Report RelatedReport { get; set; }
        public virtual Study StudyGu { get; set; }
        public virtual Style StyleGu { get; set; }
        public virtual User WriteOwnerGu { get; set; }
        public virtual ICollection<Report> InverseRelatedReport { get; set; }
        public virtual ICollection<ReportGradeInfo> ReportGradeInfos { get; set; }
        public virtual ICollection<Section> Sections { get; set; }
    }
}
