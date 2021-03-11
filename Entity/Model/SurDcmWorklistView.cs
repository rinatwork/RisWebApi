using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class SurDcmWorklistView
    {
        public string PatientId { get; set; }
        public string PName { get; set; }
        public string NamePy { get; set; }
        public string Sex { get; set; }
        public string PatientBirthDate1 { get; set; }
        public int? PatAge { get; set; }
        public string Weight { get; set; }
        public string StuInsuId { get; set; }
        public string StuId { get; set; }
        public string AccessNumber { get; set; }
        public string Yxid1 { get; set; }
        public string RMod { get; set; }
        public string RItem { get; set; }
        public Guid RType { get; set; }
        public Guid? FeeType { get; set; }
        public string SchStudyRoomId { get; set; }
        public Guid? StuPhyId { get; set; }
        public string StuPhy { get; set; }
        public string RPhisician { get; set; }
        public string RSymptom { get; set; }
        public string Location { get; set; }
        public string StudyInitSource { get; set; }
        public string SchDate1 { get; set; }
        public string SchTime1 { get; set; }
        public string StudyDate { get; set; }
        public string StudyTime { get; set; }
        public int Status { get; set; }
    }
}
