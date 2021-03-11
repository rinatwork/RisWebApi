using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class ArrangeItem
    {
        public Guid Guid { get; set; }
        public Guid ModeGuid { get; set; }
        public string Name { get; set; }
        public string Py { get; set; }
        public bool Enabled { get; set; }
        public int OrderId { get; set; }
        public string Bks1 { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }
        public DateTime? Bkd { get; set; }
        public decimal? Bki { get; set; }
        public bool? Bkb { get; set; }
        public Guid? ExamRoomGuid { get; set; }
        public Guid? IndexId { get; set; }

        public virtual Mode ModeGu { get; set; }
    }
}
