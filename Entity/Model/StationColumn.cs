using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class StationColumn
    {
        public Guid Guid { get; set; }
        public Guid StationGuid { get; set; }
        public Guid UserGuid { get; set; }
        public string Name { get; set; }
        public string EnglishName { get; set; }
        public string ClassName { get; set; }
        public string OrderName { get; set; }
        public int? OrderId { get; set; }
        public bool? IsUrgent { get; set; }
        public bool? Enabled { get; set; }
        public Guid ColumnGuid { get; set; }
    }
}
