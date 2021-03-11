using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class DangerKeyDicItemIndex
    {
        public int Id { get; set; }
        public Guid ItemGuid { get; set; }
        public int DangerKeyDicId { get; set; }

        public virtual DangerKeyDic DangerKeyDic { get; set; }
        public virtual Item ItemGu { get; set; }
    }
}
