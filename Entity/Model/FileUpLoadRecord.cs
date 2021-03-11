using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class FileUpLoadRecord
    {
        public int FileUpLoadId { get; set; }
        public int TechPlanId { get; set; }
        public string FileName { get; set; }
        public string FileLength { get; set; }
        public string FileCreator { get; set; }
        public string FileUploadTime { get; set; }
        public int? FileUpLoadStatus { get; set; }
        public string FileUploadPath { get; set; }
    }
}
