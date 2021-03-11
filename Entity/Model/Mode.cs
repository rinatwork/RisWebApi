using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class Mode
    {
        public Mode()
        {
            ArrangeItems = new HashSet<ArrangeItem>();
            ArrangeTimes = new HashSet<ArrangeTime>();
            ExamRoomModeIndices = new HashSet<ExamRoomModeIndex>();
            FeeModeIndices = new HashSet<FeeModeIndex>();
            ItemModeIndices = new HashSet<ItemModeIndex>();
            Studies = new HashSet<Study>();
            StudyTemps = new HashSet<StudyTemp>();
            StyleModeIndices = new HashSet<StyleModeIndex>();
            UserModeIndices = new HashSet<UserModeIndex>();
        }

        public Guid Guid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public Guid ModeTypeGuid { get; set; }
        public bool Enabled { get; set; }
        public string AccnumPrefix { get; set; }
        public string AccnumSuffix { get; set; }
        public bool? TimeoutFlag { get; set; }
        public int OrderId { get; set; }
        public string Bks1 { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }
        public DateTime? Bkd { get; set; }
        public decimal? Bki { get; set; }
        public bool? Bkb { get; set; }

        public virtual ModeType ModeTypeGu { get; set; }
        public virtual ICollection<ArrangeItem> ArrangeItems { get; set; }
        public virtual ICollection<ArrangeTime> ArrangeTimes { get; set; }
        public virtual ICollection<ExamRoomModeIndex> ExamRoomModeIndices { get; set; }
        public virtual ICollection<FeeModeIndex> FeeModeIndices { get; set; }
        public virtual ICollection<ItemModeIndex> ItemModeIndices { get; set; }
        public virtual ICollection<Study> Studies { get; set; }
        public virtual ICollection<StudyTemp> StudyTemps { get; set; }
        public virtual ICollection<StyleModeIndex> StyleModeIndices { get; set; }
        public virtual ICollection<UserModeIndex> UserModeIndices { get; set; }
    }
}
