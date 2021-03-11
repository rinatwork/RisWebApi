using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class StudyQuestFile
    {
        public int Id { get; set; }
        public Guid? StudyGuid { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public DateTime InsertDate { get; set; }
        public string ServerPath { get; set; }
        public bool IsRequest { get; set; }
        public Guid OwnerGuid { get; set; }
        public string OwnerName { get; set; }
        public string DisplayName { get; set; }
        public string Bks1 { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }
        public DateTime? Bkd { get; set; }
        public decimal? Bki { get; set; }
        public bool? Bkb { get; set; }
        public int VersionId { get; set; }

        public virtual User OwnerGu { get; set; }
        public virtual Study StudyGu { get; set; }
    }
}
