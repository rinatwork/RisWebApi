using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class CallingMonitor
    {
        public CallingMonitor()
        {
            CallingMonitorQueues = new HashSet<CallingMonitorQueue>();
        }

        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid WorkstationGuid { get; set; }
        public string ScrollingText { get; set; }
        public string ScrollingTextFont { get; set; }
        public double? ScrollingTextSize { get; set; }
        public string ScrollingTextColor { get; set; }
        public string HospitalName { get; set; }
        public string HospitalNameFont { get; set; }
        public double? HospitalNameSize { get; set; }
        public string HospitalNameColor { get; set; }
        public string DateTimeFont { get; set; }
        public double? DateTimeSize { get; set; }
        public string DateTimeColor { get; set; }
        public string CallingTextFont { get; set; }
        public double? CallingTextSize { get; set; }
        public string CallingTextColor { get; set; }
        public int? AutoClearTime { get; set; }
        public bool? PronounceEnabled { get; set; }
        public string VoiceName { get; set; }
        public int Volume { get; set; }
        public int PronounceTimes { get; set; }
        public int PronounceInterval { get; set; }
        public string PronounceFormat { get; set; }
        public string TextFormat { get; set; }
        public int MonitorNumber { get; set; }
        public int EnableFirstClassMonitor { get; set; }
        public int FirstClassColumnNumber { get; set; }
        public int FirstClassRowNumber { get; set; }
        public string QueueMemberFont { get; set; }
        public double QueueMemberSize { get; set; }
        public string QueueMemberColor { get; set; }
        public string QueueHeaderFont { get; set; }
        public double QueueHeaderSize { get; set; }
        public string QueueHeaderColor { get; set; }

        public virtual Workstation WorkstationGu { get; set; }
        public virtual ICollection<CallingMonitorQueue> CallingMonitorQueues { get; set; }
    }
}
