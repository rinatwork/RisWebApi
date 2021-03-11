using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class CategoryDetail
    {
        public CategoryDetail()
        {
            StudyCategoryIndices = new HashSet<StudyCategoryIndex>();
        }

        public Guid Guid { get; set; }
        public string Name { get; set; }
        public Guid CategoryTypeGuid { get; set; }
        public bool Enabled { get; set; }
        public int OrderId { get; set; }
        public string Bks1 { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }
        public DateTime? Bkd { get; set; }
        public decimal? Bki { get; set; }
        public bool? Bkb { get; set; }

        public virtual CategoryType CategoryTypeGu { get; set; }
        public virtual ICollection<StudyCategoryIndex> StudyCategoryIndices { get; set; }
    }
}
