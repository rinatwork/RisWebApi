using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class CallingMonitorInfo
    {
        public int Id { get; set; }
        public string ScrollingText { get; set; }
        public string ScrollingTextFont { get; set; }
        public double ScrollingTextSize { get; set; }
        public string ScrollingTextColor { get; set; }
        public string HospitalName { get; set; }
        public string HospitalNameFont { get; set; }
        public double HospitalNameSize { get; set; }
        public string HospitalNameColor { get; set; }
        public string DateTimeFont { get; set; }
        public double DateTimeSize { get; set; }
        public string DateTimeColor { get; set; }
        public string CallingTextFont { get; set; }
        public double CallingTextSize { get; set; }
        public string CallingTextColor { get; set; }
        public string QueueMemberFont { get; set; }
        public double QueueMemberSize { get; set; }
        public string QueueMemberColor { get; set; }
        public string QueueHeaderFont { get; set; }
        public double QueueHeaderSize { get; set; }
        public string QueueHeaderColor { get; set; }
        public string PronounceFormat { get; set; }
        public string TextFormat { get; set; }
        public string QueueMemberFormat { get; set; }
        public string XamlSource { get; set; }
        public string BackgroundFilePath { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsDefault { get; set; }
    }
}
