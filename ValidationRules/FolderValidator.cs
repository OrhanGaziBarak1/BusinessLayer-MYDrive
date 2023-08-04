using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class FolderValidator: AbstractValidator<Folder>
    {
        public FolderValidator() 
        {
            RuleFor(x => x.FolderName)
                .NotEmpty()
                .NotNull()
                .WithMessage("Folders must has a name");

            RuleFor(x => x.RootFolderID)
                .NotNull()
                .NotEmpty()
                .WithMessage("Folders must has a root folder. " +
                "(If you want to your folder has not a root folder you must enter '1'.)");
        }
    }
}
