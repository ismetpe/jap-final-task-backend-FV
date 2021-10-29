using Core.Models.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Validators
{
    public class BuyTicketValidator : AbstractValidator<AddPurchasedTicketDto>
    {
        public BuyTicketValidator()
        {
            RuleFor(p => p.NumberOfTickets).NotEmpty();
            RuleFor(p => p.DateOfBuying).NotEmpty();

        }
    }
}
