using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayakkabicim.Core.DTOs
{
    public class ProductBrandsDto:BaseDto
    {
        public string BrandsName { get; set; }
        public string BrandsWebUrl { get; set; }
        public string BrandsCode { get; set; }
        public string LogoBase64Content { get; set; }
        public string LogoFileName { get; set; }
        public string LogoFilePath { get; set; }




    }
}
