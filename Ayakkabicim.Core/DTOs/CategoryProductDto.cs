﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayakkabicim.Core.DTOs
{
    public class CategoryProductDto:CategoryDto
    {
        public List<ProductDto> Products { get; set; }
    }
}
