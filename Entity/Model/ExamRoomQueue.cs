using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class ExamRoomQueue
    {
        public int Id { get; set; }
        public Guid ExamRoomGuid { get; set; }
        public Guid QueueGuid { get; set; }
        public int OrderId { get; set; }
        public bool IsDefault { get; set; }

        public virtual ExamRoom ExamRoomGu { get; set; }
        public virtual Queue QueueGu { get; set; }
    }
}
