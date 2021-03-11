using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class FilmInfo
    {
        public FilmInfo()
        {
            Items = new HashSet<Item>();
        }

        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public int OrderId { get; set; }
        public bool Enabled { get; set; }
        public string Bks1 { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }
        public DateTime? Bkd { get; set; }
        public decimal? Bki { get; set; }
        public bool? Bkb { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}
