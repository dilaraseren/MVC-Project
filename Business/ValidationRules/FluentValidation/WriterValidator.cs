﻿using Entities.Concrete;
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
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adını Boş Geçemezsiniz.");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar Soyadını Boş Geçemezsiniz.");
            RuleFor(x => x.About).NotEmpty().WithMessage("Yazar Hakkındayı Boş Geçemezsiniz.");
            RuleFor(x => x.WriterSurname).MinimumLength(2).WithMessage("En Az 3 Karakter Girişi Yapın.");
            RuleFor(x => x.WriterSurname).MaximumLength(20).WithMessage("En Fazla 20 Karakter Girişi Yapın.");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Yazar Maili Boş Geçemezsiniz");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Ünvanı Boş Geçemezsiniz");
            RuleFor(x => x.WriterImage).NotEmpty().WithMessage("Yazar Fotoğrafı Boş Geçemezsiniz");
            RuleFor(x => x.WriterMail).EmailAddress().WithMessage("Yazar Maili Mail Adresi Türünde Olmalıdır.");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Yazar Şifreyi Boş Geçemezsiniz");
            RuleFor(x => x.WriterPassword).MinimumLength(3).WithMessage("En Az 3 Karakter Girişi Yapın.");
        }
    }
}
