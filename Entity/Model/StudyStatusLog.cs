using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class StudyStatusLog
    {
        public int Id { get; set; }
        public Guid StudyGuid { get; set; }
        public string Stage { get; set; }
        public string Status { get; set; }
        public string Comment { get; set; }
        public DateTime Time { get; set; }
        public Guid OperatorGuid { get; set; }
        public string OperatorName { get; set; }

        public virtual User OperatorGu { get; set; }
        public virtual Study StudyGu { get; set; }
    }
}
