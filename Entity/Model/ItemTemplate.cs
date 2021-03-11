using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class ItemTemplate
    {
        public int Id { get; set; }
        public Guid ItemGuid { get; set; }
        public Guid TemplateGuid { get; set; }
    }
}
