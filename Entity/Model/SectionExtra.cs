using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class SectionExtra
    {
        public Guid SectionGuid { get; set; }
        public string Field { get; set; }
        public string Value { get; set; }
        public int VersionId { get; set; }

        public virtual Section SectionGu { get; set; }
    }
}
