using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class FollowupKey
    {
        public Guid Guid { get; set; }
        public string KeyName { get; set; }
        public string KeyDescription { get; set; }
        public bool? Enabled { get; set; }
        public int? OrderId { get; set; }
        public string Bks1 { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }
    }
}
