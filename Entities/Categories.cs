﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Categories : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int ParentCategoryId { get; set; }
    }
}
