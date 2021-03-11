using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class QualityControlInfo
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public int ControlType { get; set; }
        public int? OrderId { get; set; }
        public bool Positive { get; set; }
        public bool Enabled { get; set; }
    }
}
