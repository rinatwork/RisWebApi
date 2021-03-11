using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class ItemDicomInfo
    {
        public int Id { get; set; }
        public Guid ItemGuid { get; set; }
        public Guid DeviceGuid { get; set; }
        public string DicomCode { get; set; }
        public string Bks1 { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }
        public DateTime? Bkd { get; set; }
        public decimal? Bki { get; set; }
        public bool? Bkb { get; set; }

        public virtual DeviceInfo DeviceGu { get; set; }
        public virtual Item ItemGu { get; set; }
    }
}
