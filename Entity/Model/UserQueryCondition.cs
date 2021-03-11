using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class UserQueryCondition
    {
        public Guid Guid { get; set; }
        public string Title { get; set; }
        public string Value { get; set; }
        public Guid OwnerGuid { get; set; }
        public bool Enabled { get; set; }
        public string WorkstationCode { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }
        public DateTime? Bkd { get; set; }
        public decimal? Bki { get; set; }
        public bool? Bkb { get; set; }
        public int VersionId { get; set; }

        public virtual User OwnerGu { get; set; }
    }
}
