using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class StudyExtra
    {
        public Guid StudyGuid { get; set; }
        public string Field { get; set; }
        public string Value { get; set; }
        public int VersionId { get; set; }

        public virtual Study StudyGu { get; set; }
    }
}
