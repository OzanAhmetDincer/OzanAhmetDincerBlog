using FluentValidation; // FluentValidation kütüphanesi ile class validasyonu yapmak için
using System.Reflection;

namespace OzanAhmetDincerBlog.Models
{
    public class KullaniciFluentValidation2 : AbstractValidator<KullaniciFluentValidation>//FluentValidation dan gelen AbstractValidator sınıfına kontrol ettireceğimiz classı bu şekilde belirtiyoruz
    {
        
        public KullaniciFluentValidation2()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Id Alanı Boş Geçilemez"); // Int Değerler İçin Not Empty Olmalı (NotNull String kontrolü)
            RuleFor(x => x.Ad).NotNull().WithMessage("Ad Soyad Boş Geçilemez"); ;
            RuleFor(x => x.Soyad).NotEmpty().WithMessage("Soyadı boş geçilemez!");
            RuleFor(x => x.Email).EmailAddress().NotNull().WithMessage("Email boş geçilemez!");
            RuleFor(x => x.KullaniciAdi).NotEmpty();
            RuleFor(x => x.Sifre).NotNull().WithMessage("Şifre boş geçilemez!").Length(3, 20);
        }

        
    }
}
