using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Payments : BaseEntity
    {
        public int OrderId { get; set; }

        public Orders Orders { get; set; }

        public int Amount { get; set; }

        public string Status { get; set; }

        public int PaymentTypeId { get; set; }

        public PaymentTypes PaymentTypes { get; set; }
    }
}
