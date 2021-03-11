using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class Mod
    {
        public decimal Id { get; set; }
        public string Ename { get; set; }
        public string Cname { get; set; }
        public string Discription { get; set; }
        public string Reporttype { get; set; }
        public string Templatename { get; set; }
        public Guid ModGuid { get; set; }
    }
}
