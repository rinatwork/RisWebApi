using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class CallingMonitorQueue
    {
        public int Id { get; set; }
        public Guid CallingMonitorGuid { get; set; }
        public Guid QueueGuid { get; set; }
        public bool? Ordered { get; set; }
        public int MaxRows { get; set; }
        public int MaxColumns { get; set; }
        public int MaxQuantity { get; set; }
        public string QueueMemberFont { get; set; }
        public double? QueueMemberSize { get; set; }
        public string QueueMemberColor { get; set; }
        public string QueueHeaderFont { get; set; }
        public double? QueueHeaderSize { get; set; }
        public string QueueHeaderColor { get; set; }
        public int? AutoPageTurningTime { get; set; }

        public virtual CallingMonitor CallingMonitorGu { get; set; }
        public virtual Queue QueueGu { get; set; }
    }
}
