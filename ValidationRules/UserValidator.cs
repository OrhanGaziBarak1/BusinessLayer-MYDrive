using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.UserName)
                .NotEmpty()
                .NotNull()
                .WithMessage("You must enter your name.");

            RuleFor(x => x.UserName)
            .MaximumLength(20)
            .WithMessage("Your name's length is very long.(Maximum length should be 20 characters.)");

            RuleFor(x => x.Password)
                .NotNull()
                .NotEmpty()
                .Length(8, 16)
                .WithMessage("Your password's length must be inclusive between 8 and 16 characters.");

            RuleFor(x => x.Mail)
                .NotEmpty()
                .NotNull()
                .EmailAddress()
                .WithMessage("You must enter valid email.");

            RuleFor(x => x.Mail)
                .MaximumLength(30)
                .WithMessage("Your mail address is too long.(Mail address' length must be 30 character maximum.)");

            RuleFor(x => x.RoleID)
                .NotEmpty()
                .NotNull()
                .WithMessage("You must enter a role.");
        }
    }
}
