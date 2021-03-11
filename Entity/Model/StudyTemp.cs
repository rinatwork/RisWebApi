using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class StudyTemp
    {
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
        public string DailySequence { get; set; }
        public bool? PaperPrintFlag { get; set; }
        public int? PaperPrintNum { get; set; }
        public int VersionId { get; set; }
        public bool? Danger { get; set; }
        public string DangerDesc { get; set; }
        public bool? Vip { get; set; }
        public int? ImageCount { get; set; }
        public long? SchHisSequence { get; set; }
        public int Status { get; set; }
        public int Score { get; set; }

        public virtual Department CliniDeptGu { get; set; }
        public virtual ClinicianInfo CliniDoctorGu { get; set; }
        public virtual FeeType FeeTypeGu { get; set; }
        public virtual Mode ModeGu { get; set; }
        public virtual Patient PatientGu { get; set; }
        public virtual User RegOperatorGu { get; set; }
        public virtual Region RegionGu { get; set; }
        public virtual User StudyOperatorGu { get; set; }
        public virtual VisitType VisitTypeGu { get; set; }
    }
}
