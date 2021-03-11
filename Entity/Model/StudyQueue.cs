﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class StudyQueue
    {
        public int Id { get; set; }
        public Guid StudyGuid { get; set; }
        public int CallStatus { get; set; }
        public int Priority { get; set; }
        public int OrderId { get; set; }
        public Guid StudyRoomGuid { get; set; }
        public string Bks1 { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }
        public DateTime? Bkd { get; set; }
        public decimal? Bki { get; set; }
        public bool? Bkb { get; set; }
        public int VersionId { get; set; }

        public virtual Study StudyGu { get; set; }
        public virtual ExamRoom StudyRoomGu { get; set; }
    }
}
