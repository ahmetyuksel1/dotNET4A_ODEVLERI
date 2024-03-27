using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class BrandCategories : BaseEntity
    {
        public BrandCategories()
        {
            
        }

        public BrandCategories(int id, int brandId, string description, int categoryId)
        {
            Id = id;
            BrandId = brandId;
            Description = description;
            CategoryId = categoryId;
        }

        public int BrandId { get; set; }

        public virtual Brands Brands { get; set; }

        public string Description { get; set; }

        public int CategoryId { get; set; }

        public virtual Categories Categories { get; set; }
    }
}
