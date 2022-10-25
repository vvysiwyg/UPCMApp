using System;
using System.Collections.Generic;

#nullable disable

namespace kursovajaEF
{
    public partial class GroupInfo
    {
        public int GroupInfoId { get; set; }
        public string Weekday { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string StartLearning { get; set; }
        public string EndLearning { get; set; }
        public int? GroupId { get; set; }

        public virtual Group Group { get; set; }
    }
}
