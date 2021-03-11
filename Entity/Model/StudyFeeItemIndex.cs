using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class StudyFeeItemIndex
    {
        public int Id { get; set; }
        public Guid StudyGuid { get; set; }
        public Guid FeeInfoGuid { get; set; }
        public string FeeInfoName { get; set; }
        public int Amount { get; set; }
        public decimal? Price { get; set; }
        public decimal? Total { get; set; }
        public string Unit { get; set; }
        public bool IsRealFlag { get; set; }
        public bool? IsUploadFlag { get; set; }
        public Guid? OwnerGuid { get; set; }
        public string OwnerName { get; set; }
        public DateTime? UploadDate { get; set; }
        public string Bks1 { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }
        public DateTime? Bkd { get; set; }
        public decimal? Bki { get; set; }
        public bool? Bkb { get; set; }
        public int VersionId { get; set; }

        public virtual FeeInfo FeeInfoGu { get; set; }
        public virtual User OwnerGu { get; set; }
        public virtual Study StudyGu { get; set; }
    }
}
