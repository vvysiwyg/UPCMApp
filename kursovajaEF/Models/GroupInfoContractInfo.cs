using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovajaEF.Models
{
    public partial class GroupInfoContractInfo
    {
        public int GroupInfoId { get; set; }
        public int ContractInfoId { get; set; }

        public virtual GroupInfo GroupInfo { get; set; }
        public virtual ContractInfo ContractInfo { get; set; }
    }
}