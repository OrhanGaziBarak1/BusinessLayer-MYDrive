using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class RoleAuthorityValidator: AbstractValidator<RoleAuthority>
    {
        public RoleAuthorityValidator() 
        {
            RuleFor(x => x.RoleID)
                .NotEmpty()
                .NotNull()
                .WithMessage("You must enter a value.");

            RuleFor(x => x.FolderID)
                .NotEmpty()
                .NotNull()
                .WithMessage("You must enter a value.");
        }
    }
}
