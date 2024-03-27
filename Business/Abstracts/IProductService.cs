using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IProductService
    {
        Products GetById(int id);

        List<Products> GetAll();

        void Add(Products product);

        void Update(Products product);

        void Delete(int id);
    }
}
