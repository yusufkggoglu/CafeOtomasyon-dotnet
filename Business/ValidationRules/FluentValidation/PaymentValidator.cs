using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
   public  class PaymentValidator:AbstractValidator<Payment>
    {
        public PaymentValidator()
        {
            RuleFor(p => p.PaymentTime).NotEmpty().WithMessage("Ödeme Zamanı boş olamaz !");
            RuleFor(p => p.PaymentMethod).NotEmpty().WithMessage("Ödeme şekli boş olamaz !");
            RuleFor(p => p.Price).NotEmpty().WithMessage("Ödenen tutar boş olamaz !");

            RuleFor(p => p.Price).GreaterThan(0).WithMessage("Ödenen tutar 0'dan büyük olmalı !");
        }
    }
}
