using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class StyleType
    {
        public StyleType()
        {
            StyleModeIndices = new HashSet<StyleModeIndex>();
            Styles = new HashSet<Style>();
        }

        public Guid Guid { get; set; }
        public string Name { get; set; }
        public bool Enabled { get; set; }
        public string Bks1 { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }
        public DateTime? Bkd { get; set; }
        public decimal? Bki { get; set; }
        public bool? Bkb { get; set; }

        public virtual ICollection<StyleModeIndex> StyleModeIndices { get; set; }
        public virtual ICollection<Style> Styles { get; set; }
    }
}
