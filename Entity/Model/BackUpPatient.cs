using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class BackUpPatient
    {
        public Guid BackUpGuid { get; set; }
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

        public virtual BackUpStudy BackUpGu { get; set; }
    }
}
