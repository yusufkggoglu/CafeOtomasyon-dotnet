using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.CategoryID).NotEmpty().WithMessage("Kategori  boş olamaz !");
            RuleFor(p => p.Name).NotEmpty().WithMessage("Ürün ismi boş olamaz !"); 
            RuleFor(p => p.Price).NotEmpty().WithMessage("Ürün fiyatsız olamaz !");

            RuleFor(p => p.Price).GreaterThan(0).WithMessage("Fiyat 0 veya 0'dan küçük olamaz !");
        }
    }
}
