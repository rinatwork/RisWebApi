using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class AccNumberLibrary
    {
        public Guid Id { get; set; }
        public int AccNumber { get; set; }
        public bool Locked { get; set; }
        public string LockedBy { get; set; }
        public bool? Saved { get; set; }
        public string Seedid { get; set; }
    }
}
