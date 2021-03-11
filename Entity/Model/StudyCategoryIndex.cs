using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class StudyCategoryIndex
    {
        public int Id { get; set; }
        public Guid CategoryDetailGuid { get; set; }
        public Guid StudyGuid { get; set; }

        public virtual CategoryDetail CategoryDetailGu { get; set; }
        public virtual Study StudyGu { get; set; }
    }
}
