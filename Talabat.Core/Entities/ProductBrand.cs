﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talabat.Core.Entities
{
    public class ProductBrand :BaseEntity
    {
        public string Name { get; set; }
       // [InverseProperty("Brand")]
        //public ICollection<Product> Products { get; set; } = new HashSet<Product>();//navigation prop [many] 
    }
}
