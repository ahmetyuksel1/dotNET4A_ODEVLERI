using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Customers : BaseEntity
    {
        public int UserId { get; set; }

        public Users Users { get; set; }
    }
}
