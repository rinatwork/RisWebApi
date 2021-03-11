using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class ItemModeIndex
    {
        public int Id { get; set; }
        public Guid ModeGuid { get; set; }
        public Guid ItemGuid { get; set; }
        public bool Isdefault { get; set; }

        public virtual Item ItemGu { get; set; }
        public virtual Mode ModeGu { get; set; }
    }
}
