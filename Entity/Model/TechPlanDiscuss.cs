using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class TechPlanDiscuss
    {
        public int? TechPlanId { get; set; }
        public string Dicussant { get; set; }
        public DateTime? DiscussTime { get; set; }
        public string DiscussLevel { get; set; }
        public string DiscussContentId { get; set; }
        public string DiscussContent { get; set; }
        public string DiscussTitle { get; set; }
        public int DiscussId { get; set; }
        public string BakeUp2 { get; set; }
    }
}
