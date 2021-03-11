using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class InterMessage
    {
        public InterMessage()
        {
            UserInterMessages = new HashSet<UserInterMessage>();
        }

        public Guid Guid { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Link { get; set; }
        public DateTime SentTime { get; set; }
        public Guid SenderUserGuid { get; set; }
        public string SenderName { get; set; }
        public bool IsExpired { get; set; }
        public string Bks1 { get; set; }
        public string Bks2 { get; set; }
        public string Bks3 { get; set; }
        public DateTime? Bkd { get; set; }
        public decimal? Bki { get; set; }
        public bool? Bkb { get; set; }

        public virtual User SenderUserGu { get; set; }
        public virtual ICollection<UserInterMessage> UserInterMessages { get; set; }
    }
}
