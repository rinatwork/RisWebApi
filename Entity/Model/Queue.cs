using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class Queue
    {
        public Queue()
        {
            CallingMonitorQueues = new HashSet<CallingMonitorQueue>();
            ExamRoomQueues = new HashSet<ExamRoomQueue>();
        }

        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<CallingMonitorQueue> CallingMonitorQueues { get; set; }
        public virtual ICollection<ExamRoomQueue> ExamRoomQueues { get; set; }
    }
}
