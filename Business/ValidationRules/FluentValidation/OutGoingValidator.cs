using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class OutGoingValidator:AbstractValidator<OutGoing>
    {
        public OutGoingValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Gider ismi boş olamaz !");
            RuleFor(p => p.Amount).NotEmpty().WithMessage("Ürün miktarı boş olamaz !");
            RuleFor(p => p.Price).NotEmpty().WithMessage("Fiyat boş olamaz !");

            RuleFor(p => p.Price).GreaterThan(0).WithMessage("Fiyat 0'dan büyük olmalı !");
            RuleFor(p => p.Amount).GreaterThan(0).WithMessage("Ürün miktarı 0'dan büyük olmalı !");
        }
    }
}
