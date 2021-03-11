using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class Workstation
    {
        public Workstation()
        {
            CallingMonitors = new HashSet<CallingMonitor>();
        }

        public Guid Guid { get; set; }
        public string Host { get; set; }
        public string MacAddress { get; set; }
        public string Cpu { get; set; }
        public string HardDisk { get; set; }
        public string IpAddress { get; set; }
        public string Nickname { get; set; }
        public DateTime UpdateTime { get; set; }
        public Guid? ExamRoomGuid { get; set; }
        public string WebServiceUrl { get; set; }
        public bool Enabled { get; set; }
        public int VersionId { get; set; }

        public virtual ExamRoom ExamRoomGu { get; set; }
        public virtual ICollection<CallingMonitor> CallingMonitors { get; set; }
    }
}
