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
    public class MediaValidator : AbstractValidator<AddMovieDto>
    {
        public MediaValidator()
        {
            RuleFor(p => p.Title).NotEmpty();
            RuleFor(p => p.Description).NotEmpty();
            RuleFor(p => p.Release_year).NotEmpty();
            RuleFor(p => p.img_url).NotEmpty();
        }
    }
}
