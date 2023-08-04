using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class UserAuthorityValidator : AbstractValidator<UserAuthority>
    {
        public UserAuthorityValidator()
        {
            RuleFor(x => x.UserID)
                .NotEmpty()
                .NotNull()
                .WithMessage("You must enter a user name here.");

            RuleFor(x => x.RoleID)
                .NotEmpty()
                .NotNull()
                .WithMessage("You must enter a role name here.");

            RuleFor(x => x.Create)
                .NotEmpty()
                .NotNull()
                .WithMessage("You must enter a value here. (False or True)");

            RuleFor(x => x.Read)
                .NotEmpty()
                .NotNull()
                .WithMessage("You must enter a value here. (False or True)");

            RuleFor(x => x.Write)
                .NotEmpty()
                .NotNull()
                .WithMessage("You must enter a value here. (False or True)");
        }
    }
}
