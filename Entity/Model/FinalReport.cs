using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class FinalReport
    {
        public Guid Guid { get; set; }
        public Guid StudyGuid { get; set; }
        public int ReportStatus { get; set; }
        public DateTime LastWriteTime { get; set; }
        public Guid LastWriteOwnerGuid { get; set; }
        public string LastWriteOwnerName { get; set; }
        public string LastWriteSignaturePath { get; set; }
        public DateTime WriteTime { get; set; }
        public Guid WriteOwnerGuid { get; set; }
        public string WriteOwnerName { get; set; }
        public string WriteSignaturePath { get; set; }
        public DateTime? CheckTime { get; set; }
        public Guid? CheckOwnerGuid { get; set; }
        public string CheckOwnerName { get; set; }
        public string CheckSignaturePath { get; set; }
        public DateTime? LastCheckTime { get; set; }
        public Guid? LastCheckOwnerGuid { get; set; }
        public string LastCheckOwnerName { get; set; }
        public string LastCheckSignaturePath { get; set; }
        public int? Qualitative { get; set; }
        public string PositiveDesc { get; set; }
        public string ReportImages { get; set; }
        public string ReportFilePath { get; set; }
        public int ReportLock { get; set; }
        public int? ReportPdfCount { get; set; }
    }
}
