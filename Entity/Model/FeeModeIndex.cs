using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class FeeModeIndex
    {
        public int Id { get; set; }
        public Guid ModeGuid { get; set; }
        public Guid FeeInfoGuid { get; set; }
        public bool IsDefault { get; set; }

        public virtual FeeInfo FeeInfoGu { get; set; }
        public virtual Mode ModeGu { get; set; }
    }
}
