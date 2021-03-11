using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class Group
    {
        public Group()
        {
            GroupAccesses = new HashSet<GroupAccess>();
            GroupUsers = new HashSet<GroupUser>();
        }

        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public bool Enabled { get; set; }
        public int OrderId { get; set; }
        public string Bks1 { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }
        public DateTime? Bkd { get; set; }
        public decimal? Bki { get; set; }
        public bool? Bkb { get; set; }
        public int VersionId { get; set; }

        public virtual ICollection<GroupAccess> GroupAccesses { get; set; }
        public virtual ICollection<GroupUser> GroupUsers { get; set; }
    }
}
