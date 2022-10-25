using System;
using System.Collections.Generic;

#nullable disable

namespace kursovajaEF
{
    public partial class DisciplinesTimetable
    {
        public int DisciplineId { get; set; }
        public int TtId { get; set; }

        public virtual Discipline Discipline { get; set; }
        public virtual Timetable Tt { get; set; }
    }
}
