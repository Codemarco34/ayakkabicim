using Ayakkabicim.Core.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayakkabicim.Service.Validations
{
    public class ProductColorsDtoValidator:AbstractValidator<ProductColorsDto>

    {
        public ProductColorsDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("{PropertyName} is Required").NotEmpty().WithMessage("{PropertyName} is Required");
            
        }


    }
}
