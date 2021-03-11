using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class View1
    {
        public int TechPlanId { get; set; }
        public string TechPlanName { get; set; }
        public DateTime? TechPlanCreateTime { get; set; }
        public string Author { get; set; }
        public bool? EnableShare { get; set; }
        public string StudyInfoId { get; set; }
        public int? BrowseNums { get; set; }
        public string DescriptionId { get; set; }
        public string Title { get; set; }
        public DateTime? DescripTime { get; set; }
        public string Dcontent { get; set; }
        public string KeyWords { get; set; }
    }
}
