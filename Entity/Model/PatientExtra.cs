using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class PatientExtra
    {
        public Guid PatientGuid { get; set; }
        public string Field { get; set; }
        public string Value { get; set; }
        public int VersionId { get; set; }

        public virtual Patient PatientGu { get; set; }
    }
}
