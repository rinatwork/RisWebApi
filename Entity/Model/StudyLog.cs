using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class StudyLog
    {
        public int Id { get; set; }
        public Guid StudyGuid { get; set; }
        public string ActionName { get; set; }
        public DateTime ActionTime { get; set; }
        public Guid ActorGuid { get; set; }
        public int CurrentStatus { get; set; }
        public int NextStatus { get; set; }
        public string Remark { get; set; }

        public virtual User ActorGu { get; set; }
        public virtual Study StudyGu { get; set; }
    }
}
