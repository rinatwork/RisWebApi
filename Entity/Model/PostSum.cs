using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class PostSum
    {
        public int AutoId { get; set; }
        public int? PostId { get; set; }
        public string PostName { get; set; }
        public DateTime? PostCreateTime { get; set; }
        public string PostEffective { get; set; }
        public string Uivisible { get; set; }
        public Guid PostGuid { get; set; }
    }
}
