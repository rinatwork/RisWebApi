using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class UserDefaultSetting
    {
        public UserDefaultSetting()
        {
            UserCustomedSettings = new HashSet<UserCustomedSetting>();
        }

        public Guid Guid { get; set; }
        public Guid AccessFunctionTypeGuid { get; set; }
        public string Key { get; set; }
        public string Title { get; set; }
        public string Value { get; set; }
        public string Options { get; set; }
        public int? Type { get; set; }
        public string Note { get; set; }
        public string Bks1 { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }
        public DateTime? Bkd { get; set; }
        public decimal? Bki { get; set; }
        public bool? Bkb { get; set; }
        public int VersionId { get; set; }

        public virtual AccessFunctionType AccessFunctionTypeGu { get; set; }
        public virtual ICollection<UserCustomedSetting> UserCustomedSettings { get; set; }
    }
}
