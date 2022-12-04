using System;
using System.Collections.Generic;

#nullable disable

namespace kursovajaEF
{
    public partial class Listener
    {
        public string Firstname { get; set; }
        public string Midname { get; set; }
        public string Lastname { get; set; }
        public string Yob { get; set; }
        public string Sex { get; set; }
        public string Pob { get; set; }
        public int? Series { get; set; }
        public int? Num { get; set; }
        public string Issued { get; set; }
        public int? Code { get; set; }
        public string Doi { get; set; }
        public int Id { get; set; }
        public string Matriculation { get; set; }
        public int? ContractId { get; set; }
        public decimal? PhoneNum { get; set; }
        public string SchoolName { get; set; }
        public string SchoolGrade { get; set; }
        public string Email { get; set; }
        public string ListenerCategory { get; set; }

        public virtual Contract Contract { get; set; }
    }
}
