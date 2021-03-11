using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class GroupUser
    {
        public int Id { get; set; }
        public Guid GroupGuid { get; set; }
        public Guid UsersGuid { get; set; }
        public int VersionId { get; set; }

        public virtual Group GroupGu { get; set; }
        public virtual User UsersGu { get; set; }
    }
}
