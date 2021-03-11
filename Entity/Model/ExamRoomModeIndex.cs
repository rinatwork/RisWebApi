using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class ExamRoomModeIndex
    {
        public int Id { get; set; }
        public Guid ModeTypeGuid { get; set; }
        public Guid ModeGuid { get; set; }
        public Guid ExamRoomGuid { get; set; }
        public bool IsDefault { get; set; }

        public virtual ExamRoom ExamRoomGu { get; set; }
        public virtual Mode ModeGu { get; set; }
        public virtual ModeType ModeTypeGu { get; set; }
    }
}
