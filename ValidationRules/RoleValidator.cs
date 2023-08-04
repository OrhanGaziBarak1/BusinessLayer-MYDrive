using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class RoleValidator: AbstractValidator<Role>
    {
        public RoleValidator() 
        { 
            RuleFor(x => x.RoleName)
                .NotEmpty()
                .NotNull()
                .WithMessage("You must write a role name here.");

            RuleFor(x => x.RoleName)
                .MaximumLength(10)
                .WithMessage("Your role name is too long.");
        }
    }
}
