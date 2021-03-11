using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class DepartmentRegionIndex
    {
        public int Id { get; set; }
        public Guid DepartmentGuid { get; set; }
        public Guid RegionGuid { get; set; }
        public bool IsDefault { get; set; }

        public virtual Department DepartmentGu { get; set; }
        public virtual Region RegionGu { get; set; }
    }
}
