using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IPaymentTypeService
    {
        PaymentTypes GetById(int id);

        List<PaymentTypes> GetAll();

        void Add(PaymentTypes paymentType);

        void Update(PaymentTypes paymentType);

        void Delete(int id);
    }
}
