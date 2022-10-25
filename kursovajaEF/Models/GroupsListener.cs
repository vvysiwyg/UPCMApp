using System;
using System.Collections.Generic;

#nullable disable

namespace kursovajaEF
{
    public partial class GroupsListener
    {
        public int? GroupId { get; set; }
        public int? ListenerId { get; set; }

        public virtual Group Group { get; set; }
        public virtual Listener Listener { get; set; }
    }
}
