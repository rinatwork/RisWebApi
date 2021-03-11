using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class UserKeyword
    {
        public Guid Guid { get; set; }
        public Guid UserGuid { get; set; }
        public string Keyword { get; set; }
    }
}
