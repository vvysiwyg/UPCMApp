using System;
using System.Collections.Generic;

#nullable disable

namespace kursovajaEF
{
    public partial class GroupInfoListener
    {
        public int? GroupInfoId { get; set; }
        public int? ListenerId { get; set; }

        public virtual GroupInfo GroupInfo { get; set; }
        public virtual Listener Listener { get; set; }
    }
}
