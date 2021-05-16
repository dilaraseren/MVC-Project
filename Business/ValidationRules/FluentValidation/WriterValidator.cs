using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {

            RuleFor(r => r.WriterName).NotEmpty().WithMessage("Kategori adı boş geçilemez !");
            RuleFor(r => r.WriterSurname).NotEmpty().WithMessage("Açıklama boş geçilemez !");
            RuleFor(r => r.WriterName).MinimumLength(2).WithMessage("Kategori adı en az 2 karakter olmalıdır.");
            RuleFor(r => r.WriterSurname).MinimumLength(2).WithMessage("Kategori adı en az 2 karakter olmalıdır.");
            RuleFor(r => r.About).MaximumLength(20).WithMessage("Kategori adı en fazla 100 karakter olmalıdır.");
        }
    }
}
