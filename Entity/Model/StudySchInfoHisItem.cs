using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class StudySchInfoHisItem
    {
        public long Id { get; set; }
        public long? Sequence { get; set; }
        public Guid? ItemGuid { get; set; }
    }
}
