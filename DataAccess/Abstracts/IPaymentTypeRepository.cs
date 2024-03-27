using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface IPaymentTypeRepository
    {
        PaymentTypes GetById(int id);

        List<PaymentTypes> GetAll();

        void Add(PaymentTypes paymentType);

        void Update(PaymentTypes paymentType);

        void Delete(PaymentTypes paymentType);
    }
}
