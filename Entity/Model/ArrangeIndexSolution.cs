using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class ArrangeIndexSolution
    {
        public Guid Guid { get; set; }
        public Guid? ExamRoomGuid { get; set; }
        public Guid? ModeGuid { get; set; }
        public string Name { get; set; }
        public DateTime? DateTime { get; set; }
        public int? Status { get; set; }
        public DateTime? AppliedTime { get; set; }
    }
}
