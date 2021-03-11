using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class StudyStatusChange
    {
        public int Id { get; set; }
        public Guid StudyGuid { get; set; }
        public string StudyStatus { get; set; }
        public int SendStatus { get; set; }
        public string SendObject { get; set; }
        public DateTime InsertDate { get; set; }
        public string EventCode { get; set; }
        public string RequestId { get; set; }

        public virtual Study StudyGu { get; set; }
    }
}
