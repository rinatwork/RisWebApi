using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class UserModeIndex
    {
        public int Id { get; set; }
        public Guid UsersGuid { get; set; }
        public Guid ModeGuid { get; set; }

        public virtual Mode ModeGu { get; set; }
        public virtual User UsersGu { get; set; }
    }
}
