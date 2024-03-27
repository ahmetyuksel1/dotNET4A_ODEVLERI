using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IPaymentService
    {
        Payments GetById(int id);

        List<Payments> GetAll();

        void Add(Payments payment);

        void Update(Payments payment);

        void Delete(int id);
    }
}
