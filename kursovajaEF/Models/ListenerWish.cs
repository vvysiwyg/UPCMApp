using System;
using System.Collections.Generic;

#nullable disable

namespace kursovajaEF
{
    public partial class ListenerWish
    {
        public int WishId { get; set; }
        public string Weekday { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int? ContractId { get; set; }

        public virtual Contract Contract { get; set; }
    }
}
