using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class QualityControlMonth
    {
        public QualityControlMonth()
        {
            QualityControlDetails = new HashSet<QualityControlDetail>();
        }

        public Guid Guid { get; set; }
        public DateTime YearMonth { get; set; }
        public int ControlType { get; set; }
        public Guid EvaluatedUserId { get; set; }
        public Guid EvaluatorUserId { get; set; }
        public Guid ModeGuid { get; set; }
        public int SearchMode { get; set; }
        public int SearchCount { get; set; }
        public int AlphaCount { get; set; }
        public int BetaCount { get; set; }
        public int GammaCount { get; set; }
        public int DeltaCount { get; set; }
        public string Bkb { get; set; }
        public string Bks { get; set; }
        public string Bki { get; set; }
        public string Bks1 { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }
        public int? VersionId { get; set; }
        public DateTime? LastOperationTime { get; set; }

        public virtual ICollection<QualityControlDetail> QualityControlDetails { get; set; }
    }
}
