using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class NumberSeed
    {
        public Guid Id { get; set; }
        public int Seed { get; set; }
        public bool Enabled { get; set; }
        public int? MaxNo { get; set; }
        public string NumType { get; set; }
    }
}
