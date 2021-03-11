using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class Patient
    {
        public Patient()
        {
            DangerLogs = new HashSet<DangerLog>();
            PatientExtras = new HashSet<PatientExtra>();
            PatientVips = new HashSet<PatientVip>();
            Studies = new HashSet<Study>();
            StudyTemps = new HashSet<StudyTemp>();
        }

        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string NamePinYin { get; set; }
        public string Py { get; set; }
        public string Sex { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string PostCode { get; set; }
        public string Email { get; set; }
        public string Idcard { get; set; }
        public string Ybkh { get; set; }
        public string Blh { get; set; }
        public string ImgId { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public bool Vip { get; set; }
        public string Bks1 { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }
        public DateTime? Bkd { get; set; }
        public decimal? Bki { get; set; }
        public bool? Bkb { get; set; }
        public int VersionId { get; set; }
        public int? HisPidInt { get; set; }
        public Guid? HisPidGuid { get; set; }
        public string HisPidStr { get; set; }

        public virtual ICollection<DangerLog> DangerLogs { get; set; }
        public virtual ICollection<PatientExtra> PatientExtras { get; set; }
        public virtual ICollection<PatientVip> PatientVips { get; set; }
        public virtual ICollection<Study> Studies { get; set; }
        public virtual ICollection<StudyTemp> StudyTemps { get; set; }
    }
}
