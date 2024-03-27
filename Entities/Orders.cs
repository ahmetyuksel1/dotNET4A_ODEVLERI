using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Orders : BaseEntity
    {
        public int ProductId { get; set; }

        public Products Products { get; set; }

        public DateTime StartDate { get; set; }
        
        public DateTime EndDate { get; set; }

        //public int CustomerId { get; set; }

        //public Customers Customers { get; set; }

        public int Quantity { get; set; }

        public int PaymentId { get; set; }

        public Payments Payments { get; set; }
    }
}
