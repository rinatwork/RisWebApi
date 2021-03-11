using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class SmartprintGetimagedatum
    {
        public string Pname { get; set; }
        public string Pnamepy { get; set; }
        public DateTime Birthdate { get; set; }
        public string Age { get; set; }
        public string Sex { get; set; }
        public DateTime Studydate { get; set; }
        public string Accnum { get; set; }
        public string Modality { get; set; }
        public string Studyitem { get; set; }
        public string Examdevice { get; set; }
        public string Ybkh { get; set; }
        public int? Patientid { get; set; }
        public string Jzkh { get; set; }
        public string Idcard { get; set; }
        public string Blkh { get; set; }
        public string Jclx { get; set; }
        public string Rks { get; set; }
        public string Orderdoctor { get; set; }
        public string Orderdepartment { get; set; }
        public string Reportdoctor { get; set; }
        public string Approvedoctor { get; set; }
        public DateTime? Reportdate { get; set; }
        public DateTime? Approvedate { get; set; }
        public string Reportmethod { get; set; }
        public string Reportfinding { get; set; }
        public string Reportdignosis { get; set; }
        public string Reportnote { get; set; }
        public int Reportstatus { get; set; }
        public string Pdfreporturl { get; set; }
    }
}
