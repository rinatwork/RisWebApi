using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class Tpdiscuss
    {
        public int? TechPlanId { get; set; }
        public int DiscussId { get; set; }
        public string Dicussant { get; set; }
        public DateTime? DiscussTime { get; set; }
        public string DiscussLevel { get; set; }
    }
}
