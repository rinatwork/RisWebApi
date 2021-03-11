using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class BackUpStudy
    {
        public BackUpStudy()
        {
            BackUpStudyFeeItemIndices = new HashSet<BackUpStudyFeeItemIndex>();
            BackUpStudyItemIndices = new HashSet<BackUpStudyItemIndex>();
            BackUpStudyQuestFiles = new HashSet<BackUpStudyQuestFile>();
            BackUpStudySchInfos = new HashSet<BackUpStudySchInfo>();
        }

        public Guid BackUpGuid { get; set; }
        public Guid Guid { get; set; }
        public Guid PatientGuid { get; set; }
        public int InitState { get; set; }
        public string AccNum { get; set; }
        public Guid ModeGuid { get; set; }
        public string ModeName { get; set; }
        public string CliniAge { get; set; }
        public string CliniAgeUnit { get; set; }
        public string CliniRequestId { get; set; }
        public string CliniItem { get; set; }
        public Guid? CliniDeptGuid { get; set; }
        public Guid? CliniDoctorGuid { get; set; }
        public string CliniSymptom { get; set; }
        public string CliniDiagnosis { get; set; }
        public string CliniBodyDescription { get; set; }
        public string CliniHistoryDes { get; set; }
        public string CliniStudyDesc { get; set; }
        public DateTime? CliniStudyDate { get; set; }
        public Guid VisitTypeGuid { get; set; }
        public string VisitNo { get; set; }
        public Guid? RegionGuid { get; set; }
        public string BedNo { get; set; }
        public string StudyItemNames { get; set; }
        public string StudyStatus { get; set; }
        public string StudyStage { get; set; }
        public DateTime RegDate { get; set; }
        public Guid RegOperatorGuid { get; set; }
        public DateTime? StudyDate { get; set; }
        public Guid? StudyOperatorGuid { get; set; }
        public Guid? FeeTypeGuid { get; set; }
        public bool Urgent { get; set; }
        public string Barcode { get; set; }
        public string Comment { get; set; }
        public bool? ScanFlag { get; set; }
        public bool? ImgFlag { get; set; }
        public bool? IsFilmFlag { get; set; }
        public int? PrintFilmState { get; set; }
        public bool? ReportPrintFlag { get; set; }
        public int? ReportPrintNum { get; set; }
        public bool? SplitFlag { get; set; }
        public string ReferAccnum { get; set; }
        public DateTime? EstimateCompleteDate { get; set; }
        public string StudyInitSource { get; set; }
        public string Bks1 { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }
        public DateTime? Bkd { get; set; }
        public decimal? Bki { get; set; }
        public bool? Bkb { get; set; }

        public virtual BackUpPatient BackUpPatient { get; set; }
        public virtual ICollection<BackUpStudyFeeItemIndex> BackUpStudyFeeItemIndices { get; set; }
        public virtual ICollection<BackUpStudyItemIndex> BackUpStudyItemIndices { get; set; }
        public virtual ICollection<BackUpStudyQuestFile> BackUpStudyQuestFiles { get; set; }
        public virtual ICollection<BackUpStudySchInfo> BackUpStudySchInfos { get; set; }
    }
}
