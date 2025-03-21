using FitnessTracker.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.FluentValidation
{
    internal class UserValidator : AbstractValidator<User>
    {
        public UserValidator() 
        {
            RuleFor(a => a.Name)
                .NotEmpty()
                .NotNull().WithMessage("aucilebeliaa")
                .Length(2, 100).WithMessage("ert asoze meti unda iyos");

            RuleFor(a => a.Email)
                .NotEmpty()
                .NotEmpty()
                .Matches("@");

            RuleFor(a => a.Password)
                .NotEmpty()
                .Length(8, 20);
        }
    }
}
