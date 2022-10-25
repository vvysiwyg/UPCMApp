using System;
using System.Collections.Generic;

#nullable disable

namespace kursovajaEF
{
    public partial class Timetable
    {
        public int TtId { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Weekday { get; set; }
    }
}
