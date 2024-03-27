using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IBrandCategoryService
    {
        BrandCategories GetById(int id);

        List<BrandCategories> GetAll();

        void Add(BrandCategories brandCategory);

        void Update(BrandCategories brandCategory);

        void Delete(int id);

    }
}
