using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface IPaymentRepository
    {
        Payments GetById(int id);

        List<Payments> GetAll();

        void Add(Payments payment);

        void Update(Payments payment);

        void Delete(Payments payment);
    }
}
