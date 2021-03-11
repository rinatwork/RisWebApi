using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class SubPathological
    {
        public int Aid { get; set; }
        public int Pid { get; set; }
        public int Sid { get; set; }
        public int? SidParent { get; set; }
        public string Description { get; set; }
        public string DescriptionEn { get; set; }

        public virtual Pathological Pathological { get; set; }
    }
}
