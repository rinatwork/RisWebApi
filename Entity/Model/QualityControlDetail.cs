using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class QualityControlDetail
    {
        public QualityControlDetail()
        {
            QualityControlLogs = new HashSet<QualityControlLog>();
        }

        public Guid Guid { get; set; }
        public Guid StudyGuid { get; set; }
        public Guid QualityControlMonthGuid { get; set; }
        public Guid EvaluatedUserId { get; set; }
        public Guid EvaluatorUserId { get; set; }
        public int ControlType { get; set; }
        public string Comment { get; set; }
        public DateTime OperationTime { get; set; }
        public int Grade { get; set; }
        public string Bkb { get; set; }
        public string Bks { get; set; }
        public string Bki { get; set; }
        public string Bks1 { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }

        public virtual QualityControlMonth QualityControlMonthGu { get; set; }
        public virtual Study StudyGu { get; set; }
        public virtual ICollection<QualityControlLog> QualityControlLogs { get; set; }
    }
}
