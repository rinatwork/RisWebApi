using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class FinalSection
    {
        public Guid Guid { get; set; }
        public Guid FinalReportGuid { get; set; }
        public string Title { get; set; }
        public string ExamItems { get; set; }
        public string Method { get; set; }
        public string Description { get; set; }
        public string Diagnosis { get; set; }
        public string Note { get; set; }
        public Guid? StyleGuid { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Age { get; set; }
        public string BackUpTxt1 { get; set; }
        public string BackUpTxt2 { get; set; }
        public string BackUpTxt3 { get; set; }
    }
}
