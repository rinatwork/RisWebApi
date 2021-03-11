using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class DangerKeyDic
    {
        public DangerKeyDic()
        {
            DangerKeyDicItemIndices = new HashSet<DangerKeyDicItemIndex>();
        }

        public int Id { get; set; }
        public Guid? ItemGuid { get; set; }
        public string KeyName { get; set; }
        public string KeyDescribe { get; set; }
        public Guid? ItemTypeGuid { get; set; }
        public int? KeyType { get; set; }
        public Guid ModeTypeGuid { get; set; }
        public bool? Enabled { get; set; }
        public string Bks1 { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }

        public virtual Item ItemGu { get; set; }
        public virtual ItemType ItemTypeGu { get; set; }
        public virtual ModeType ModeTypeGu { get; set; }
        public virtual ICollection<DangerKeyDicItemIndex> DangerKeyDicItemIndices { get; set; }
    }
}
