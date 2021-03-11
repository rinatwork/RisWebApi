using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Model
{
    public partial class QueueContainerDb
    {
        public Guid ContainerGuid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Members { get; set; }
        public int VersionId { get; set; }
    }
}
