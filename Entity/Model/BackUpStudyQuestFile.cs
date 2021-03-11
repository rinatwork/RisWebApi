using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class BackUpStudyQuestFile
    {
        public int Id { get; set; }
        public Guid BackUpGuid { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public DateTime InsertDate { get; set; }
        public string ServerPath { get; set; }
        public Guid OwnerGuid { get; set; }
        public string OwnerName { get; set; }
        public string DisplayName { get; set; }
        public string Bks1 { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }
        public DateTime? Bkd { get; set; }
        public decimal? Bki { get; set; }
        public bool? Bkb { get; set; }

        public virtual BackUpStudy BackUpGu { get; set; }
    }
}
