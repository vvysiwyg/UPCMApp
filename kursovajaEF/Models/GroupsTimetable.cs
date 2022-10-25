using System;
using System.Collections.Generic;

#nullable disable

namespace kursovajaEF
{
    public partial class GroupsTimetable
    {
        public int GroupId { get; set; }
        public int TtId { get; set; }

        public virtual Group Group { get; set; }
        public virtual Timetable Tt { get; set; }
    }
}
