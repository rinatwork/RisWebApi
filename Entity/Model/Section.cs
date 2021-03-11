using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class Section
    {
        public Section()
        {
            SectionExtras = new HashSet<SectionExtra>();
        }

        public Guid Guid { get; set; }
        public Guid ReportGuid { get; set; }
        public string Title { get; set; }
        public string ExamItems { get; set; }
        public string Method { get; set; }
        public string Description { get; set; }
        public string Diagnosis { get; set; }
        public string Note { get; set; }
        public int OrderId { get; set; }
        public Guid? StyleGuid { get; set; }
        public string Bks1 { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }
        public DateTime? Bkd { get; set; }
        public decimal? Bki { get; set; }
        public bool? Bkb { get; set; }
        public int VersionId { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Age { get; set; }
        public string BackUpTxt1 { get; set; }
        public string BackUpTxt2 { get; set; }
        public string BackUpTxt3 { get; set; }

        public virtual Report ReportGu { get; set; }
        public virtual Style StyleGu { get; set; }
        public virtual ICollection<SectionExtra> SectionExtras { get; set; }
    }
}
