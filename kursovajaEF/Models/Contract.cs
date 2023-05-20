using kursovajaEF.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace kursovajaEF
{
    public partial class Contract
    {
        public Contract()
        {
            ContractInfos = new HashSet<ContractInfo>();
            ListenerWishes = new HashSet<ListenerWish>();
            ListenerEnrollmentOrders = new HashSet<ListenerEnrollmentOrder>();
            ListenerExpulsionOrders = new HashSet<ListenerExpulsionOrder>();
        }

        public string Crn { get; set; }
        public decimal? TotalSum { get; set; }
        public decimal? PayedSum { get; set; }
        public string PayDate40pct { get; set; }
        public string ExpulsionDate { get; set; }
        public string ListenedHours { get; set; }
        public string TransferGroup { get; set; }
        public decimal? RestOfSum { get; set; }
        public string IssueCertificate { get; set; }
        public string Certificate { get; set; }
        public string WhoPay { get; set; }
        public bool? Paid40pct { get; set; }
        public int ContractId { get; set; }
        public string PaymentDeadline { get; set; }
        public string Bank { get; set; }
        public int? ListenerId { get; set; }

        public virtual Listener Listener { get; set; }
        public virtual ICollection<ListenerEnrollmentOrder> ListenerEnrollmentOrders { get; set; }
        public virtual ICollection<ListenerExpulsionOrder> ListenerExpulsionOrders { get; set; }
        public virtual ICollection<ContractInfo> ContractInfos { get; set; }
        public virtual ICollection<ListenerWish> ListenerWishes { get; set; }
    }
}
