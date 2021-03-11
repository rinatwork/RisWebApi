using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class DataStream
    {
        public int StreamId { get; set; }
        public string StreamName { get; set; }
        public string StreamDescription { get; set; }
        public string StreamSource { get; set; }
        public string StreamTarget { get; set; }
        public string StreamStruct { get; set; }
    }
}
