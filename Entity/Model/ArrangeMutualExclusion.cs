using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class ArrangeMutualExclusion
    {
        public Guid Aguid { get; set; }
        public Guid Bguid { get; set; }
        public int Duration { get; set; }
        public byte[] Comment { get; set; }
    }
}
