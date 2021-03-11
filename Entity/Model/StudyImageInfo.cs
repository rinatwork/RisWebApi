using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class StudyImageInfo
    {
        public int Id { get; set; }
        public Guid StudyGuid { get; set; }
        public Guid DeviceGuid { get; set; }
        public decimal? LightExposure { get; set; }
        public int? ImageCount { get; set; }
        public int? ImageGrade { get; set; }
        public string ImageGradeNote { get; set; }
        public Guid? ImageGradeOwnerGuid { get; set; }
        public DateTime? ImageGradeDate { get; set; }
        public decimal? LightCount { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }
        public DateTime? Bkd { get; set; }
        public decimal? Bki { get; set; }
        public bool? Bkb { get; set; }
        public int VersionId { get; set; }

        public virtual DeviceInfo DeviceGu { get; set; }
        public virtual User ImageGradeOwnerGu { get; set; }
        public virtual Study StudyGu { get; set; }
    }
}
