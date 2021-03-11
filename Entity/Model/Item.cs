using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class Item
    {
        public Item()
        {
            DangerKeyDicItemIndices = new HashSet<DangerKeyDicItemIndex>();
            DangerKeyDics = new HashSet<DangerKeyDic>();
            ItemDiagFilters = new HashSet<ItemDiagFilter>();
            ItemDicomInfos = new HashSet<ItemDicomInfo>();
            ItemFeeIndices = new HashSet<ItemFeeIndex>();
            ItemModeIndices = new HashSet<ItemModeIndex>();
            ItemSplitDetailItemGus = new HashSet<ItemSplitDetail>();
            ItemSplitDetailItemSplitGus = new HashSet<ItemSplitDetail>();
            StudyItemIndices = new HashSet<StudyItemIndex>();
        }

        public Guid Guid { get; set; }
        public Guid ModeTypeGuid { get; set; }
        public Guid ItemTypeGuid { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Py { get; set; }
        public int OrderId { get; set; }
        public bool Enabled { get; set; }
        public bool? Isdefault { get; set; }
        public bool? SplitFlag { get; set; }
        public Guid? FilmGuid { get; set; }
        public int? FilmNum { get; set; }
        public decimal? Weight { get; set; }
        public int? ReportTime { get; set; }
        public bool? IsFilter { get; set; }
        public string Bks1 { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }
        public DateTime? Bkd { get; set; }
        public decimal? Bki { get; set; }
        public bool? Bkb { get; set; }
        public string ExamRoomList { get; set; }
        public Guid? DefaultExamRoom { get; set; }

        public virtual FilmInfo FilmGu { get; set; }
        public virtual ItemType ItemTypeGu { get; set; }
        public virtual ModeType ModeTypeGu { get; set; }
        public virtual ICollection<DangerKeyDicItemIndex> DangerKeyDicItemIndices { get; set; }
        public virtual ICollection<DangerKeyDic> DangerKeyDics { get; set; }
        public virtual ICollection<ItemDiagFilter> ItemDiagFilters { get; set; }
        public virtual ICollection<ItemDicomInfo> ItemDicomInfos { get; set; }
        public virtual ICollection<ItemFeeIndex> ItemFeeIndices { get; set; }
        public virtual ICollection<ItemModeIndex> ItemModeIndices { get; set; }
        public virtual ICollection<ItemSplitDetail> ItemSplitDetailItemGus { get; set; }
        public virtual ICollection<ItemSplitDetail> ItemSplitDetailItemSplitGus { get; set; }
        public virtual ICollection<StudyItemIndex> StudyItemIndices { get; set; }
    }
}
