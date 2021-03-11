using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class DeviceInfo
    {
        public DeviceInfo()
        {
            ItemDicomInfos = new HashSet<ItemDicomInfo>();
            StudyImageInfos = new HashSet<StudyImageInfo>();
        }

        public Guid Guid { get; set; }
        public Guid ExamRoomGuid { get; set; }
        public string Manufacturer { get; set; }
        public string ModelName { get; set; }
        public string Comment { get; set; }
        public string Aetitle { get; set; }
        public string ExposureUnit { get; set; }
        public string ExposureDefault { get; set; }
        public DateTime? GuaranteeDate { get; set; }
        public string Phone { get; set; }
        public int OrderId { get; set; }
        public bool IsDefault { get; set; }
        public bool Enabled { get; set; }
        public string Bks1 { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }
        public DateTime? Bkd { get; set; }
        public decimal? Bki { get; set; }
        public bool? Bkb { get; set; }

        public virtual ExamRoom ExamRoomGu { get; set; }
        public virtual ICollection<ItemDicomInfo> ItemDicomInfos { get; set; }
        public virtual ICollection<StudyImageInfo> StudyImageInfos { get; set; }
    }
}
