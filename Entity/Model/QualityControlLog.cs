using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class QualityControlLog
    {
        public Guid Guid { get; set; }
        public Guid StudyGuid { get; set; }
        public Guid QualityControlDetailGuid { get; set; }
        public Guid QualityControlMonthGuid { get; set; }
        public Guid EvaluatedUserId { get; set; }
        public Guid EvaluatorUserId { get; set; }
        public int ControlType { get; set; }
        public string Comment { get; set; }
        public DateTime OperationTime { get; set; }
        public int Grade { get; set; }
        public DateTime LogTime { get; set; }
        public string Bkb { get; set; }
        public string Bks { get; set; }
        public string Bki { get; set; }
        public string Bks1 { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }

        public virtual QualityControlDetail QualityControlDetailGu { get; set; }
    }
}
