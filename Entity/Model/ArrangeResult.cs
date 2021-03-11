using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class ArrangeResult
    {
        public long Sequence { get; set; }
        public string CardId { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string AgeUnit { get; set; }
        public string Sex { get; set; }
        public string Blkh { get; set; }
        public string VisitNumber { get; set; }
        public string VisitType { get; set; }
        public Guid? Department { get; set; }
        public Guid? Doctor { get; set; }
        public Guid? RoomGuid { get; set; }
        public string SchDate { get; set; }
        public Guid? SchItemGuid { get; set; }
        public Guid? SchTimeGuid { get; set; }
        public string SlotTime { get; set; }
        public int? Slot { get; set; }
        public bool? IsDel { get; set; }
        public Guid? ModeGuid { get; set; }
        public DateTime? ApplicaitonTime { get; set; }
        public string Itemname { get; set; }
    }
}
