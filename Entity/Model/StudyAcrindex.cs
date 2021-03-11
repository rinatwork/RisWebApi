using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class StudyAcrindex
    {
        public int Id { get; set; }
        public Guid StudyGuid { get; set; }
        public string AnotomicalCode { get; set; }
        public string PathologicalCode { get; set; }

        public virtual Study StudyGu { get; set; }
    }
}
