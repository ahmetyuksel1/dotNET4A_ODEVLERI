using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface IOrderRepository
    {
        Orders GetById(int id);

        List<Orders> GetAll();

        void Add(Orders order);

        void Update(Orders order);

        void Delete(Orders order);
    }
}
