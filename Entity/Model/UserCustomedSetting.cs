using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class UserCustomedSetting
    {
        public int Id { get; set; }
        public Guid UserGuid { get; set; }
        public Guid UserDefaultSettingsGuid { get; set; }
        public string Value { get; set; }
        public int VersionId { get; set; }

        public virtual UserDefaultSetting UserDefaultSettingsGu { get; set; }
        public virtual User UserGu { get; set; }
    }
}
