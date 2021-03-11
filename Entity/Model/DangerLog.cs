using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class DangerLog
    {
        public int Id { get; set; }
        public Guid StudyGuid { get; set; }
        public Guid PatientGuid { get; set; }
        public int SourceType { get; set; }
        public Guid SetUserGuid { get; set; }
        public DateTime SetTime { get; set; }
        public string DangerDescribe { get; set; }
        public Guid? CancelUserId { get; set; }
        public DateTime? CancelTime { get; set; }
        public string CancelReason { get; set; }
        public string HandleName { get; set; }
        public DateTime? HandleTime { get; set; }
        public string HandleRemark { get; set; }
        public int Status { get; set; }
        public string DangerKeyName { get; set; }

        public virtual User CancelUser { get; set; }
        public virtual Patient PatientGu { get; set; }
        public virtual User SetUserGu { get; set; }
        public virtual Study StudyGu { get; set; }
    }
}
