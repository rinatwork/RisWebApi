using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class staff
    {
        public staff()
        {
            TechPlans = new HashSet<TechPlan>();
        }

        public int AutoId { get; set; }
        public string StaffId { get; set; }
        public string Name { get; set; }
        public string PassWord { get; set; }
        public string BelongPost { get; set; }
        public string Permission { get; set; }
        public string Skill { get; set; }
        public string ShiftNums { get; set; }
        public string ShiftRule { get; set; }
        public string BelongClass { get; set; }
        public Guid UserGuid { get; set; }

        public virtual ICollection<TechPlan> TechPlans { get; set; }
    }
}
