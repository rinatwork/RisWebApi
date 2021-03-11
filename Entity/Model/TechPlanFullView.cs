using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class TechPlanFullView
    {
        public int TechPlanId { get; set; }
        public string TechPlanName { get; set; }
        public DateTime? TechPlanCreateTime { get; set; }
        public string Author { get; set; }
        public string Sharestatus { get; set; }
        public string StudyInfoId { get; set; }
        public int? BrowseNums { get; set; }
        public string DescriptionId { get; set; }
        public string Title { get; set; }
        public DateTime? DescripTime { get; set; }
        public string Dcontent { get; set; }
        public string KeyWords { get; set; }
        public string Dicussant { get; set; }
        public DateTime? DiscussTime { get; set; }
        public string DiscussLevel { get; set; }
        public string DiscussContentId { get; set; }
        public string DiscussContent { get; set; }
        public string DiscussTitle { get; set; }
        public int? DiscussNums { get; set; }
        public int? Expr1 { get; set; }
        public bool? EnableShare { get; set; }
        public int? AuthorId { get; set; }
        public bool? HasUsed { get; set; }
    }
}
