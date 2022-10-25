using System;
using System.Collections.Generic;

#nullable disable

namespace kursovajaEF
{
    public partial class Group
    {
        public Group()
        {
            GroupInfos = new HashSet<GroupInfo>();
        }

        public string GroupNum { get; set; }
        public int GroupId { get; set; }
        public int? DisciplineId { get; set; }
        public int? NumOfHours { get; set; }
        public string DisciplineName { get; set; }

        public virtual Discipline Discipline { get; set; }
        public virtual ICollection<GroupInfo> GroupInfos { get; set; }
    }
}
