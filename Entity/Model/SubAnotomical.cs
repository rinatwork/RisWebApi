using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class SubAnotomical
    {
        public int Aid { get; set; }
        public int Sid { get; set; }
        public int? SidParent { get; set; }
        public string Description { get; set; }
        public string DescriptionEn { get; set; }

        public virtual Anotomical AidNavigation { get; set; }
    }
}
