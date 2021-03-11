using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class CaseRecord
    {
        public int RecNo { get; set; }
        public string AccNum { get; set; }
        public int? CaseId { get; set; }
        public DateTime? OperateTime { get; set; }
        public string Operator { get; set; }
        public string OperateType { get; set; }
    }
}
