﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class DyestuffReportParamsView
    {
        public string PatientName { get; set; }
        public string Sex { get; set; }
        public DateTime Birthday { get; set; }
        public string VisitNumber { get; set; }
        public DateTime? FilmDate { get; set; }
        public string Department { get; set; }
        public string Bed { get; set; }
        public string VisitType { get; set; }
        public DateTime ReportDate { get; set; }
        public string DeviceCompany { get; set; }
        public string DeviceName { get; set; }
        public string AccessionNumber { get; set; }
        public DateTime? AppraiseDate { get; set; }
        public string ExamName { get; set; }
        public string Method { get; set; }
        public string Description { get; set; }
        public string Diagnosis { get; set; }
        public string ReportPhysician { get; set; }
        public string AppraisePhysician { get; set; }
        public string ImageNumber { get; set; }
        public string ModeName { get; set; }
        public string Param1 { get; set; }
        public string Param2 { get; set; }
    }
}
