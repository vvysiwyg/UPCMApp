using System;
using System.Collections.Generic;

#nullable disable

namespace kursovajaEF
{
    public partial class DisciplinesTeacher
    {
        public int DisciplineId { get; set; }
        public int? TeacherId { get; set; }

        public virtual Discipline Discipline { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
