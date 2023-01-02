﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayakkabicim.Core.Models
{
    public class ProductVatUnits : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string IsExemtion { get; set; }
        public string Explanation { get; set; }
        public ICollection <ProductFeatures> ProductFeatures { get; set; }
    }
}
