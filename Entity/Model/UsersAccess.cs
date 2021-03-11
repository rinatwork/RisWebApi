using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class UsersAccess
    {
        public int Id { get; set; }
        public Guid UsersGuid { get; set; }
        public Guid AccessFunctionGuid { get; set; }
        public int VersionId { get; set; }

        public virtual User UsersGu { get; set; }
    }
}
