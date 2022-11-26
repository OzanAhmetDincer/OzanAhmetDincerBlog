using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using OzanAhmetDincerBlog.Models;

namespace OzanAhmetDincerBlog.Controllers
{
    public class FluentValidationKayitController : Controller
    {
        private readonly IValidator<KullaniciFluentValidation> _validator; // FluentValidation ı kullanarak doğrulama yapabilmek için
        public IActionResult Index()
        {
            return View();
        }

        public FluentValidationKayitController(IValidator<KullaniciFluentValidation> validator) // bu işleme dependency injection denir
        {
            _validator = validator; // burada yukarıda tanımladığımız _validator nesnesinin içerisi doldurulur.
        }

        [HttpPost]
        public async Task<IActionResult> IndexAsync(KullaniciFluentValidation kullanici)
        {
            FluentValidation.Results.ValidationResult result = await _validator.ValidateAsync(kullanici); // kullanici nesnesi için FluentValidation ile doğrulama yap

            if (!result.IsValid) // doğrulama başarısızsa
            {
                foreach (var error in result.Errors) // oluşan hatalar içinde dön
                {
                    ModelState.Remove(error.PropertyName); // .net core hata mesajını kaldır
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage); // ModelState e FluentValidation hatalarını ekle
                    ModelState.AddModelError("", error.ErrorMessage); // hataları üst kısımda göstermek için
                }
                return View("Index", kullanici);
            }
            // Eğer validasyon başarılıysa burada ilgili işlem yaptırılır.
            TempData["mesaj"] = "Kayıt Başarılı!";
            return RedirectToAction("Index"); // işlem başarılıysa index e yönlendir
        }
    }
}
