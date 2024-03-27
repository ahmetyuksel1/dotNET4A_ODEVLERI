using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Products : BaseEntity
    {
        public Products()
        {
            
        }
        
        public Products(int id, string name, int categoryId, int price, string description, int brandId)
        {
            Id = id;
            Name = name;
            CategoryId = categoryId;
            Price = price;
            Description = description;
            BrandId = brandId;
        }

        public string Name { get; set; }

        public int CategoryId { get; set; }

        public virtual Categories Categories { get; set; }

        public int Price { get; set; }

        public string Description { get; set; }

        public int BrandId { get; set; }

        public virtual Brands Brands { get; set; }
    }
}
