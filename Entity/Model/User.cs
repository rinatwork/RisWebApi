using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class User
    {
        public User()
        {
            DangerLogCancelUsers = new HashSet<DangerLog>();
            DangerLogSetUserGus = new HashSet<DangerLog>();
            GroupUsers = new HashSet<GroupUser>();
            InterMessages = new HashSet<InterMessage>();
            ReportCheckOwnerGus = new HashSet<Report>();
            ReportGradeInfos = new HashSet<ReportGradeInfo>();
            ReportWriteOwnerGus = new HashSet<Report>();
            StudyDiagnoseQualityLogs = new HashSet<StudyDiagnoseQualityLog>();
            StudyDiagnoseQualityOwnerGus = new HashSet<StudyDiagnoseQuality>();
            StudyDiagnoseQualityPatientGus = new HashSet<StudyDiagnoseQuality>();
            StudyFeeItemIndices = new HashSet<StudyFeeItemIndex>();
            StudyImageInfos = new HashSet<StudyImageInfo>();
            StudyLocks = new HashSet<StudyLock>();
            StudyLogs = new HashSet<StudyLog>();
            StudyQuestFiles = new HashSet<StudyQuestFile>();
            StudyRegOperatorGus = new HashSet<Study>();
            StudyStatusLogs = new HashSet<StudyStatusLog>();
            StudyStudyOperatorGus = new HashSet<Study>();
            StudyTempRegOperatorGus = new HashSet<StudyTemp>();
            StudyTempStudyOperatorGus = new HashSet<StudyTemp>();
            StudyTimeAxes = new HashSet<StudyTimeAxis>();
            UserCustomedSettings = new HashSet<UserCustomedSetting>();
            UserInterMessages = new HashSet<UserInterMessage>();
            UserModeIndices = new HashSet<UserModeIndex>();
            UserQueryConditions = new HashSet<UserQueryCondition>();
            UsersAccesses = new HashSet<UsersAccess>();
        }

        public Guid Guid { get; set; }
        public string Gh { get; set; }
        public string Name { get; set; }
        public string Py { get; set; }
        public string Sex { get; set; }
        public DateTime? Birthday { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
        public Guid? RoleGuid { get; set; }
        public Guid? TechnicalGuid { get; set; }
        public bool Enabled { get; set; }
        public bool? IsInner { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int OrderId { get; set; }
        public string Bks1 { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }
        public DateTime? Bkd { get; set; }
        public decimal? Bki { get; set; }
        public bool? Bkb { get; set; }
        public string DefaultStation { get; set; }
        public int VersionId { get; set; }

        public virtual RolePost RoleGu { get; set; }
        public virtual TechnicalPost TechnicalGu { get; set; }
        public virtual ICollection<DangerLog> DangerLogCancelUsers { get; set; }
        public virtual ICollection<DangerLog> DangerLogSetUserGus { get; set; }
        public virtual ICollection<GroupUser> GroupUsers { get; set; }
        public virtual ICollection<InterMessage> InterMessages { get; set; }
        public virtual ICollection<Report> ReportCheckOwnerGus { get; set; }
        public virtual ICollection<ReportGradeInfo> ReportGradeInfos { get; set; }
        public virtual ICollection<Report> ReportWriteOwnerGus { get; set; }
        public virtual ICollection<StudyDiagnoseQualityLog> StudyDiagnoseQualityLogs { get; set; }
        public virtual ICollection<StudyDiagnoseQuality> StudyDiagnoseQualityOwnerGus { get; set; }
        public virtual ICollection<StudyDiagnoseQuality> StudyDiagnoseQualityPatientGus { get; set; }
        public virtual ICollection<StudyFeeItemIndex> StudyFeeItemIndices { get; set; }
        public virtual ICollection<StudyImageInfo> StudyImageInfos { get; set; }
        public virtual ICollection<StudyLock> StudyLocks { get; set; }
        public virtual ICollection<StudyLog> StudyLogs { get; set; }
        public virtual ICollection<StudyQuestFile> StudyQuestFiles { get; set; }
        public virtual ICollection<Study> StudyRegOperatorGus { get; set; }
        public virtual ICollection<StudyStatusLog> StudyStatusLogs { get; set; }
        public virtual ICollection<Study> StudyStudyOperatorGus { get; set; }
        public virtual ICollection<StudyTemp> StudyTempRegOperatorGus { get; set; }
        public virtual ICollection<StudyTemp> StudyTempStudyOperatorGus { get; set; }
        public virtual ICollection<StudyTimeAxis> StudyTimeAxes { get; set; }
        public virtual ICollection<UserCustomedSetting> UserCustomedSettings { get; set; }
        public virtual ICollection<UserInterMessage> UserInterMessages { get; set; }
        public virtual ICollection<UserModeIndex> UserModeIndices { get; set; }
        public virtual ICollection<UserQueryCondition> UserQueryConditions { get; set; }
        public virtual ICollection<UsersAccess> UsersAccesses { get; set; }
    }
}
