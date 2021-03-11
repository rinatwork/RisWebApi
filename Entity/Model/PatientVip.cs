using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class PatientVip
    {
        public Guid Guid { get; set; }
        public Guid PatientGuid { get; set; }
        public byte[] Name { get; set; }
        public byte[] NamePinYin { get; set; }
        public byte[] Py { get; set; }
        public byte[] Sex { get; set; }
        public byte[] Birthday { get; set; }
        public byte[] Address { get; set; }
        public byte[] Phone { get; set; }
        public byte[] PostCode { get; set; }
        public byte[] Email { get; set; }
        public byte[] Idcard { get; set; }
        public string Ybkh { get; set; }
        public string Blh { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Bks1 { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }
        public string Bkd { get; set; }
        public string Bki { get; set; }
        public string Bkb { get; set; }

        public virtual Patient PatientGu { get; set; }
    }
}
