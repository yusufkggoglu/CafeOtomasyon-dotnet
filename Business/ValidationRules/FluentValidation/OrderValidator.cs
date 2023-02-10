using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    class OrderValidator:AbstractValidator<Order>
    {
        public OrderValidator()
        {
            RuleFor(p => p.TableID).NotEmpty().WithMessage("Sipariş bir masaya ait olmalı !");
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Sipariş içeriği boş olamaz !");
            RuleFor(p => p.Price).NotEmpty().WithMessage("Sipariş fiyatı boş olamaz !");
            RuleFor(p => p.Amount).NotEmpty().WithMessage("Sipariş edilen ürün miktarı boş olamaz !");
            RuleFor(p => p.OrderTime).NotEmpty().WithMessage("Sipariş Saati boş olamaz !");
            RuleFor(p => p.UserID).NotEmpty().WithMessage("Sipariş eden kullanıcı algılanamadı !");

            RuleFor(p => p.Amount).GreaterThan(0).WithMessage("Sipariş miktarı 0'dan büyük olmalı !");
            RuleFor(p => p.Price).GreaterThan(0).WithMessage("Sipariş fiyatı  0'dan büyük olmalı !");
        }
    }
}
