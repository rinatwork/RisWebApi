using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class StudyPrintingLog
    {
        public int Id { get; set; }
        public Guid StudyGuid { get; set; }
        public Guid OperatorGuid { get; set; }
        public string OperatorName { get; set; }
        public string PrintSite { get; set; }
        public DateTime InsertDate { get; set; }
        public string Note { get; set; }
        public string Bks1 { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }
        public DateTime? Bkd { get; set; }
        public decimal? Bki { get; set; }
        public bool? Bkb { get; set; }

        public virtual Study StudyGu { get; set; }
    }
}
