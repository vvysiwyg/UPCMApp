using kursovajaEF.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace kursovajaEF
{
    public partial class Teacher
    {
        public string Fio { get; set; }
        public string Dob { get; set; }
        public string Title { get; set; }
        public string Position { get; set; }
        public string PedagogicalExperience { get; set; }
        public string OverallExperience { get; set; }
        public string Degree { get; set; }
        public decimal? PhoneNum { get; set; }
        public string Email { get; set; }
        public int TeacherId { get; set; }
        public int? ChairId { get; set; }

        public virtual Chair Chair { get; set; }
    }
}
