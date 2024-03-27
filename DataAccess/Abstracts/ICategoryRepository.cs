using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface ICategoryRepository
    {
        Categories GetById(int id);

        List<Categories> GetAll();

        void Add(Categories category);

        void Update(Categories category);

        void Delete(Categories category);
    }
}
