using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class Icdcode
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool? IsLeaf { get; set; }
    }
}
