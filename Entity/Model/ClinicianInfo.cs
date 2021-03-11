using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class ClinicianInfo
    {
        public ClinicianInfo()
        {
            DepartmentClinicianIndices = new HashSet<DepartmentClinicianIndex>();
            Studies = new HashSet<Study>();
            StudyTemps = new HashSet<StudyTemp>();
        }

        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Py { get; set; }
        public int OrderId { get; set; }
        public bool Enabled { get; set; }
        public string Bks1 { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }
        public DateTime? Bkd { get; set; }
        public decimal? Bki { get; set; }
        public bool? Bkb { get; set; }
        public string Tel { get; set; }
        public string Phone { get; set; }
        public string ArrangeUser { get; set; }
        public string ArrangePwd { get; set; }

        public virtual ICollection<DepartmentClinicianIndex> DepartmentClinicianIndices { get; set; }
        public virtual ICollection<Study> Studies { get; set; }
        public virtual ICollection<StudyTemp> StudyTemps { get; set; }
    }
}
