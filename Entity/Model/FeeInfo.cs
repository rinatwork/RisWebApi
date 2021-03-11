using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class FeeInfo
    {
        public FeeInfo()
        {
            FeeModeIndices = new HashSet<FeeModeIndex>();
            ItemFeeIndices = new HashSet<ItemFeeIndex>();
            StudyFeeItemIndices = new HashSet<StudyFeeItemIndex>();
        }

        public Guid Guid { get; set; }
        public Guid ModeTypeGuid { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Py { get; set; }
        public int? Amount { get; set; }
        public decimal? Price { get; set; }
        public string Unit { get; set; }
        public string Spec { get; set; }
        public int OrderId { get; set; }
        public bool Enabled { get; set; }
        public string Source { get; set; }
        public bool? IsPublic { get; set; }
        public bool? IsDefault { get; set; }
        public string Bks1 { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }
        public DateTime? Bkd { get; set; }
        public decimal? Bki { get; set; }
        public bool? Bkb { get; set; }

        public virtual ModeType ModeTypeGu { get; set; }
        public virtual ICollection<FeeModeIndex> FeeModeIndices { get; set; }
        public virtual ICollection<ItemFeeIndex> ItemFeeIndices { get; set; }
        public virtual ICollection<StudyFeeItemIndex> StudyFeeItemIndices { get; set; }
    }
}
