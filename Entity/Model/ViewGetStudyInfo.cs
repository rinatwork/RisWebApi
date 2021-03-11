using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class ViewGetStudyInfo
    {
        public string Patientid { get; set; }
        public string Rmod { get; set; }
        public DateTime? Birdat { get; set; }
        public string AccNum { get; set; }
        public string Sextitle { get; set; }
        public string Ritem { get; set; }
        public string Repphy { get; set; }
        public DateTime? Studate { get; set; }
        public string ReportUrl { get; set; }
        public string Stuid { get; set; }
        public Guid StudyId { get; set; }
        public string ItemNames { get; set; }
    }
}
