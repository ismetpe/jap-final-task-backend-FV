using Core.Entities;
using Core.Models.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Validators
{
    public class ScreeningValidator : AbstractValidator<AddScreeningDto>
    {

        public ScreeningValidator()
        {
            RuleFor(p => p.Time).NotEmpty();
            RuleFor(p => p.Number_of_seats).NotEmpty().NotNull();
            RuleFor(p => p.Number_of_tickets).NotEmpty().NotNull();
            RuleFor(p => p.Place).NotEmpty().NotNull();
            RuleFor(p => p.Date).NotEmpty().NotNull();
        }
    }
}
