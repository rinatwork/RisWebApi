using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class Tpdescription
    {
        public string DescriptionId { get; set; }
        public string Title { get; set; }
        public DateTime? DescripTime { get; set; }
        public string Dcontent { get; set; }
        public int? TechPlanId { get; set; }
        public string KeyWords { get; set; }
    }
}
