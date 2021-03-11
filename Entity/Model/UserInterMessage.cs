using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class UserInterMessage
    {
        public int Id { get; set; }
        public Guid InterMessageGuid { get; set; }
        public Guid OwnerGuid { get; set; }
        public bool IsRead { get; set; }
        public bool IsRemoved { get; set; }

        public virtual InterMessage InterMessageGu { get; set; }
        public virtual User OwnerGu { get; set; }
    }
}
