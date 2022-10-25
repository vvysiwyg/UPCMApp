using System;
using System.Collections.Generic;

#nullable disable

namespace kursovajaEF
{
    public partial class GroupsTeacher
    {
        public int GroupId { get; set; }
        public int TeacherId { get; set; }

        public virtual Group Group { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
