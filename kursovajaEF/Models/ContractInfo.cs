using System;
using System.Collections.Generic;

#nullable disable

namespace kursovajaEF
{
    public partial class ContractInfo
    {
        public int ContractInfoId { get; set; }
        public string DisciplineName { get; set; }
        public short? StudyHours { get; set; }
        public short? NumOfPeople { get; set; }
        public int? ContractId { get; set; }
        public int? DisciplineId { get; set; }

        public virtual Contract Contract { get; set; }
        public virtual Discipline Discipline { get; set; }
    }
}
