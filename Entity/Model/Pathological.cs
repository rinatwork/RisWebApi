using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class Pathological
    {
        public Pathological()
        {
            SubPathologicals = new HashSet<SubPathological>();
        }

        public int Aid { get; set; }
        public int Pid { get; set; }
        public string Description { get; set; }
        public string DescriptionEn { get; set; }

        public virtual Anotomical AidNavigation { get; set; }
        public virtual ICollection<SubPathological> SubPathologicals { get; set; }
    }
}
