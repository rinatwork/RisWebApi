using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class CheckItemSum
    {
        public int AutoId { get; set; }
        public int CheckItemId { get; set; }
        public string CheckItemName { get; set; }
        public string BakeUp { get; set; }
    }
}
