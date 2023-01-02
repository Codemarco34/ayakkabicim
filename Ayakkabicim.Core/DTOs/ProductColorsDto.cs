using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayakkabicim.Core.DTOs
{
    public class ProductColorsDto:BaseDto
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public string ColorBase64Content { get; set; }


    }
}
