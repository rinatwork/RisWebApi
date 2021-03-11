using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class DepartmentClinicianIndex
    {
        public int Id { get; set; }
        public Guid DepartmentGuid { get; set; }
        public Guid ClinicianGuid { get; set; }
        public bool IsDefault { get; set; }

        public virtual ClinicianInfo ClinicianGu { get; set; }
        public virtual Department DepartmentGu { get; set; }
    }
}
