using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class TableValidator:AbstractValidator<Table>
    {
        public TableValidator()
        {
            RuleFor(p => p.TableName).NotEmpty().WithMessage("Masa ismi boş olamaz !");
        }
    }
}
