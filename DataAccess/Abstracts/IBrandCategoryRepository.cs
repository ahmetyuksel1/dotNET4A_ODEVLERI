using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface IBrandCategoryRepository
    {
        Products GetById(int id);

        List<Products> GetAll();

        void Add(Products product);

        void Update(Products product);

        void Delete(Products product);
    }
}
