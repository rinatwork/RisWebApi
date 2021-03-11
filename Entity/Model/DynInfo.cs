using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class DynInfo
    {
        public int AutoId { get; set; }
        public string InfoId { get; set; }
        public int? OperatorId { get; set; }
        public string Operator { get; set; }
        public string OperatorType { get; set; }
        public string OperatorContent { get; set; }
        public string TechPlanId { get; set; }
        public string TechPlanName { get; set; }
        public DateTime? TechPlanCreateTime { get; set; }
        public int? RelationId { get; set; }
        public string RelationName { get; set; }
        public DateTime? RelationCreateTime { get; set; }
    }
}
