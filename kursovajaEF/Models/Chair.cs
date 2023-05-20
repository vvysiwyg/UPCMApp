using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovajaEF.Models
{
    public partial class Chair
    {
        public Chair()
        {
            Teachers = new HashSet<Teacher>();
        }

        public int ChairId { get; set; }
        public string ChairName { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
