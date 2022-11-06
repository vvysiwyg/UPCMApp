using System;
using System.Collections.Generic;

#nullable disable

namespace kursovajaEF
{
    public partial class GroupInfoTeacher
    {
        public int? GroupInfoId { get; set; }
        public int? TeacherId { get; set; }

        public virtual GroupInfo GroupInfo { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}