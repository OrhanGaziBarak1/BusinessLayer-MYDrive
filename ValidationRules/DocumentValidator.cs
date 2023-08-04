using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class DocumentValidator : AbstractValidator<Document>
    {
        public DocumentValidator()
        {
            RuleFor(x => x.DocumentName)
                .NotEmpty()
                .NotNull()
                .WithMessage("Your document must has a name.");

            RuleFor(x => x.DocumentName)
                .MaximumLength(20)
                .WithMessage("Your document name is too long. (Maximum length must be 20 characters.)");

            RuleFor(x => x.FolderID)
                .NotEmpty()
                .NotNull()
                .WithMessage("Your document must has a folder.");

            //RuleFor(x => x.DocumentTypeID)
            //    .NotEmpty()
            //    .NotNull()
            //    .WithMessage("Your document must has a type.");

        }
    }
}
