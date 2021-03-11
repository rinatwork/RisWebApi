using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class RightManage
    {
        public int RightId { get; set; }
        public string RightName { get; set; }
        public string RightDescription { get; set; }
        public string ForCollections { get; set; }
        public string RightOperate { get; set; }
    }
}
