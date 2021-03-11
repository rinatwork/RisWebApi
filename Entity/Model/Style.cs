using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class Style
    {
        public Style()
        {
            Reports = new HashSet<Report>();
            Sections = new HashSet<Section>();
            StyleModeIndices = new HashSet<StyleModeIndex>();
        }

        public Guid Guid { get; set; }
        public Guid StyleTypeGuid { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }
        public string Header { get; set; }
        public string Footer { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool Enabled { get; set; }
        public int PrintNum { get; set; }
        public string PrintName { get; set; }
        public string Bks1 { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }
        public DateTime? Bkd { get; set; }
        public decimal? Bki { get; set; }
        public bool? Bkb { get; set; }
        public string PageSizeType { get; set; }
        public bool? IsEmergency { get; set; }

        public virtual StyleType StyleTypeGu { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
        public virtual ICollection<Section> Sections { get; set; }
        public virtual ICollection<StyleModeIndex> StyleModeIndices { get; set; }
    }
}
