using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Orders : BaseEntity
    {
        public Orders()
        {
            
        }

        public Orders(int id, int productId, DateTime startDate, DateTime endDate, int quantity, int paymentId)
        {
            Id = id;
            ProductId = productId;
            StartDate = startDate;
            EndDate = endDate;
            Quantity = quantity;
            PaymentId = paymentId;
        }

        public int ProductId { get; set; }

        public Products Products { get; set; }

        public DateTime StartDate { get; set; }
        
        public DateTime EndDate { get; set; }

        public int Quantity { get; set; }

        public int PaymentId { get; set; }

        public Payments Payments { get; set; }
    }
}
