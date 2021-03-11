using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class TechPlan
    {
        public int TechPlanId { get; set; }
        public string TechPlanName { get; set; }
        public DateTime? TechPlanCreateTime { get; set; }
        public int? AuthorId { get; set; }
        public string Author { get; set; }
        public bool? EnableShare { get; set; }
        public string StudyInfoId { get; set; }
        public int? BrowseNums { get; set; }
        public int? DiscussNums { get; set; }
        public bool? HasUsed { get; set; }
        public string Ttype { get; set; }

        public virtual staff AuthorNavigation { get; set; }
    }
}
