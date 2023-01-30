using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovajaEF.Models
{
    public partial class ListenerExpulsionOrder
    {
        public int ListenerExpulsionOrderId { get; set; }
        public int Number { get; set; }
        public string Date { get; set; }
        public int? ContractId { get; set; }
        public virtual Contract Contract { get; set; }
    }
}
