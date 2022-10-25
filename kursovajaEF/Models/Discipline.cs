using System;
using System.Collections.Generic;

#nullable disable

namespace kursovajaEF
{
    public partial class Discipline
    {
        public Discipline()
        {
            Groups = new HashSet<Group>();
        }

        public int DisciplineId { get; set; }
        public string DisciplineName { get; set; }
        public string StudyPeriod { get; set; }
        public short? HoursOfStudy { get; set; }

        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<ContractInfo> ContractInfos { get; set; }
    }
}
