using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class ItemFeeIndex
    {
        public int Id { get; set; }
        public Guid ItemGuid { get; set; }
        public Guid FeeGuid { get; set; }

        public virtual FeeInfo FeeGu { get; set; }
        public virtual Item ItemGu { get; set; }
    }
}
