using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PaymentTypes : BaseEntity
    {
        public PaymentTypes()
        {
            
        }
        
        public PaymentTypes(int id, string paymentType)
        {
            Id = id;
            PaymentType = paymentType;
        }

        public string PaymentType { get; set; }
    }
}
