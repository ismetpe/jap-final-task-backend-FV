using Core.Models.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Validators
{
    public class RegistrationValidator : AbstractValidator<UserRegistrationDto>
    {
        public RegistrationValidator()
        {
            RuleFor(p => p.Username).NotEmpty();
            RuleFor(p => p.Password).NotEmpty();
        
        }
    }
}
