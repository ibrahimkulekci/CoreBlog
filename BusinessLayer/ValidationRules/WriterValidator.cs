using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator: AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adı Soyadı Alanı Boş Geçilemez.")
                .MinimumLength(2).WithMessage("Yazar Ad Soyad En Az 2 Karakter Girişi Yapılmalıdır.")
                .MaximumLength(50).WithMessage("Yazar Ad Soyad En Fazla 50 Karakter Girişi Yapılmalıdır.");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Yazar E-Mail Alanı Boş Geçilemez.");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Yazar Password Alanı Boş Geçilemez.")
                .Matches(@"[A-Z]+").WithMessage("Yazar Şifre Alanı En Az 1 Büyük Harf, 1 Küçük Harf ve 1 Sayı İçermelidir.")
                .Matches(@"[a-z]+").WithMessage("Yazar Şifre Alanı En Az 1 Büyük Harf, 1 Küçük Harf ve 1 Sayı İçermelidir.")
                .Matches(@"[0-9]+").WithMessage("Yazar Şifre Alanı En Az 1 Büyük Harf, 1 Küçük Harf ve 1 Sayı İçermelidir.");
            
        }
    }
}
