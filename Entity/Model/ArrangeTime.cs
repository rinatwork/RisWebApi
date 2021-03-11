using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class ArrangeTime
    {
        public ArrangeTime()
        {
            ArrangeIndices = new HashSet<ArrangeIndex>();
            StudySchInfos = new HashSet<StudySchInfo>();
        }

        public Guid Guid { get; set; }
        public Guid ModeGuid { get; set; }
        public string BeginTime { get; set; }
        public string EndTime { get; set; }
        public int TimeType { get; set; }
        public bool Enabled { get; set; }
        public int OrderId { get; set; }
        public string Bks1 { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }
        public DateTime? Bkd { get; set; }
        public decimal? Bki { get; set; }
        public bool? Bkb { get; set; }
        public Guid? IndexId { get; set; }
        public string Name { get; set; }

        public virtual Mode ModeGu { get; set; }
        public virtual ICollection<ArrangeIndex> ArrangeIndices { get; set; }
        public virtual ICollection<StudySchInfo> StudySchInfos { get; set; }
    }
}
