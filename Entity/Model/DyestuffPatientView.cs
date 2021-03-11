using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class DyestuffPatientView
    {
        public string AccessionNumber { get; set; }
        public string ImageNumber { get; set; }
        public string PatientName { get; set; }
        public string Sex { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime RegisterDate { get; set; }
        public string Mode { get; set; }
        public DateTime? ReportDate { get; set; }
        public DateTime? AppraiseDate { get; set; }
        public int Status { get; set; }
        public Guid PatientId { get; set; }
    }
}
