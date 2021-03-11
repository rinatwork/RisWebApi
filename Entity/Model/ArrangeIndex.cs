using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class ArrangeIndex
    {
        public int Id { get; set; }
        public Guid? ArrangeItemGuid { get; set; }
        public Guid ArrangeTimeGuid { get; set; }
        public int WeekdayNum { get; set; }
        public int WeekendNum { get; set; }
        public int? ClinicWeekdayNum { get; set; }
        public int? ClinicWeekendNum { get; set; }
        public string Bks1 { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }
        public DateTime? Bkd { get; set; }
        public decimal? Bki { get; set; }
        public bool? Bkb { get; set; }
        public string Name { get; set; }
        public DateTime? DateTime { get; set; }
        public Guid? SolutionGuid { get; set; }

        public virtual ArrangeTime ArrangeTimeGu { get; set; }
    }
}
