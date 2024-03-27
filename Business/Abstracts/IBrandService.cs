using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IBrandService
    {
        Brands GetById(int id);

        List<Brands> GetAll();

        void Add(Brands brand);

        void Update(Brands brand);

        void Delete(int id);
    }
}
