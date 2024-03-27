﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class BrandCategory : BaseEntity
    {
        public int BrandId { get; set; }

        public virtual Brands Brands { get; set; }

        public string Description { get; set; }

        public int CategoryId { get; set; }

        public virtual Categories Categories { get; set; }
    }
}
