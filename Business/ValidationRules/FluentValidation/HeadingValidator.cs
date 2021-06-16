using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
   public class HeadingValidator : AbstractValidator<Heading>
    {
        public HeadingValidator()
        {
            RuleFor(r => r.HeadingName).NotEmpty().WithMessage("Başlık adı boş geçilemez !");
            RuleFor(r => r.Writer.WriterImage).NotEmpty().WithMessage("Yazar Görseli boş olamaz !");
            RuleFor(r => r.Category.CategoryName).MinimumLength(3).WithMessage("Kategori adı en az 3 karakter olmalıdır.");
            RuleFor(r => r.Category.CategoryName).NotEmpty().WithMessage("Kategori adı boş geçilemez!");
            

        }
    
    }
}
