using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class StudyKeyImage
    {
        public int Id { get; set; }
        public Guid StudyGuid { get; set; }
        public string ServerPath { get; set; }
        public string ImagePath { get; set; }
        public string ImageName { get; set; }
        public bool ImageFlag { get; set; }
        public DateTime InsertDate { get; set; }
        public string Bks1 { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }
        public DateTime? Bkd { get; set; }
        public decimal? Bki { get; set; }
        public bool? Bkb { get; set; }
        public int VersionId { get; set; }

        public virtual Study StudyGu { get; set; }
    }
}
