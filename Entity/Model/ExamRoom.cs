using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class ExamRoom
    {
        public ExamRoom()
        {
            DeviceInfos = new HashSet<DeviceInfo>();
            ExamRoomModeIndices = new HashSet<ExamRoomModeIndex>();
            ExamRoomQueues = new HashSet<ExamRoomQueue>();
            StudyQueues = new HashSet<StudyQueue>();
            Workstations = new HashSet<Workstation>();
        }

        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public string Code { get; set; }
        public string Py { get; set; }
        public int OrderId { get; set; }
        public bool Enabled { get; set; }
        public string Bks1 { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }
        public DateTime? Bkd { get; set; }
        public decimal? Bki { get; set; }
        public bool? Bkb { get; set; }
        public Guid? ModeTypeGuid { get; set; }

        public virtual ICollection<DeviceInfo> DeviceInfos { get; set; }
        public virtual ICollection<ExamRoomModeIndex> ExamRoomModeIndices { get; set; }
        public virtual ICollection<ExamRoomQueue> ExamRoomQueues { get; set; }
        public virtual ICollection<StudyQueue> StudyQueues { get; set; }
        public virtual ICollection<Workstation> Workstations { get; set; }
    }
}
