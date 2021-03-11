using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class StudyDiagnoseQualityLog
    {
        public int Id { get; set; }
        public int Sdqid { get; set; }
        public Guid? StudyGuid { get; set; }
        public string SeeFromOperation { get; set; }
        public string Pathology { get; set; }
        public string ChemicalExam { get; set; }
        public string RadiateExam { get; set; }
        public string Result { get; set; }
        public int CoincidenceFlag { get; set; }
        public bool ConsistenceFlag { get; set; }
        public Guid OwnerGuid { get; set; }
        public DateTime InsertDate { get; set; }
        public string Bks1 { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }
        public DateTime? Bkd { get; set; }
        public decimal? Bki { get; set; }
        public bool? Bkb { get; set; }
        public int VersionId { get; set; }
        public int? Status { get; set; }
        public string Acrcode { get; set; }
        public int? Sdqtype { get; set; }
        public Guid? DoctorGuid { get; set; }
        public Guid? PatientGuid { get; set; }
        public DateTime? OperateTime { get; set; }
        public string Ultrasound { get; set; }
        public string Comment { get; set; }
        public string AccNum { get; set; }

        public virtual User OwnerGu { get; set; }
        public virtual StudyDiagnoseQuality Sdq { get; set; }
        public virtual Study StudyGu { get; set; }
    }
}
