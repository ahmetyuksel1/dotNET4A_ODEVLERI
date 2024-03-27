using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Categories : BaseEntity
    {
        public Categories()
        {
            
        }

        public Categories(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}
