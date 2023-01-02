using Ayakkabicim.Core.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayakkabicim.Service.Validations
{
    public class ProductDtoValidator:AbstractValidator<ProductDto>

    {
        public ProductDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("{PropertyName} is Required").NotEmpty().WithMessage("{PropertyName} is Required");
            RuleFor(x => x.SalePrice).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} 0 dan büyük olması gerekiyor");
            RuleFor(x => x.CategoryId).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} Kategori Id 0 olamaz");



        }


    }
}
