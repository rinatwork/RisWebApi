using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class ItemSplitDetail
    {
        public int Id { get; set; }
        public Guid ItemGuid { get; set; }
        public Guid ItemSplitGuid { get; set; }

        public virtual Item ItemGu { get; set; }
        public virtual Item ItemSplitGu { get; set; }
    }
}
