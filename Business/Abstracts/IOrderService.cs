using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IOrderService
    {
        Orders GetById(int id);

        List<Orders> GetAll();

        void Add(Orders order);

        void Update(Orders order);

        void Delete(int id);
    }
}
