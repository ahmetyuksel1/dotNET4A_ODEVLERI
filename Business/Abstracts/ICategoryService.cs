using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICategoryService
    {
        Categories GetById(int id);

        List<Categories> GetAll();

        void Add(Categories category);

        void Update(Categories category);

        void Delete(int id);
    }
}
