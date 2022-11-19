using Microsoft.AspNetCore.Mvc;
using OzanAhmetDincerBlog.Models;

namespace OzanAhmetDincerBlog.Controllers
{
    public class ModelValidationIletisimController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(IletisimModel uye)
        {
            if (ModelState.IsValid) // Eğer model nesnesi (uye) validasyon kuralları geçerliyse
            {
                // Kurallara uyulmuşsa uye nesnesini veritabanına ekle
            }
            if (!ModelState.IsValid) // ! model durmu geçersizse
            {
                // kullanıcıya hata mesajı göster
                ModelState.AddModelError("", "Lütfen tüm zorunlu alanları doldurunuz!"); // Bu metotla ekrana kendi hata mesajlarımızı da gönderebiliriz.
            }
            return View(uye);
        }

        public IActionResult UyeListesi()
        {
            var uyeListesi = new List<KullaniciBilgisi>()
            {
                new KullaniciBilgisi() { Id = 18, IsimSoyisim= "Alp Arslan", Eposta = "alp@arslan.net"},
                new KullaniciBilgisi() { Id = 25, IsimSoyisim= "Murat Yılmaz", Eposta = "murat@yilmaz.net"},
                new KullaniciBilgisi() { Id = 34, IsimSoyisim= "Pusat Kılıç", Eposta = "pusat@arslan.net"}
            };
            uyeListesi.Add(new KullaniciBilgisi() { Id = 1453, IsimSoyisim = "Fatih Sultan", Eposta = "fatih@sultan.net" });

            return View(uyeListesi); // sayfaya model olarak uyelistesini yolladık
        }
    }
}
