using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class Anotomical
    {
        public Anotomical()
        {
            Pathologicals = new HashSet<Pathological>();
            SubAnotomicals = new HashSet<SubAnotomical>();
        }

        public int Aid { get; set; }
        public string Description { get; set; }
        public string DescriptionEn { get; set; }

        public virtual ICollection<Pathological> Pathologicals { get; set; }
        public virtual ICollection<SubAnotomical> SubAnotomicals { get; set; }
    }
}
