using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class StyleModeIndex
    {
        public int Id { get; set; }
        public Guid ModeGuid { get; set; }
        public Guid StyleTypeGuid { get; set; }
        public Guid StyleGuid { get; set; }
        public bool IsDefault { get; set; }
        public bool Enabled { get; set; }

        public virtual Mode ModeGu { get; set; }
        public virtual Style StyleGu { get; set; }
        public virtual StyleType StyleTypeGu { get; set; }
    }
}
