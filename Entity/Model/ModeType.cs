using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class ModeType
    {
        public ModeType()
        {
            DangerKeyDics = new HashSet<DangerKeyDic>();
            ExamRoomModeIndices = new HashSet<ExamRoomModeIndex>();
            FeeInfos = new HashSet<FeeInfo>();
            Items = new HashSet<Item>();
            Modes = new HashSet<Mode>();
        }

        public Guid Guid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public string HisPerformedDeptCode { get; set; }
        public string HisFeeCode { get; set; }
        public bool Enabled { get; set; }
        public int OrderId { get; set; }
        public string Bks1 { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }
        public DateTime? Bkd { get; set; }
        public decimal? Bki { get; set; }
        public bool? Bkb { get; set; }

        public virtual ICollection<DangerKeyDic> DangerKeyDics { get; set; }
        public virtual ICollection<ExamRoomModeIndex> ExamRoomModeIndices { get; set; }
        public virtual ICollection<FeeInfo> FeeInfos { get; set; }
        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<Mode> Modes { get; set; }
    }
}
