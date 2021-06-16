using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ContactValidator :AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adı boş geçilemez!");
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail Alanı boş geçilemez!");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu boş geçilemez!");
            RuleFor(x => x.Message).NotEmpty().WithMessage("Mesaj boş geçilemez!");
        }
    }
}
