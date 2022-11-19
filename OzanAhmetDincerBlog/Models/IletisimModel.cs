using System.ComponentModel.DataAnnotations;

namespace OzanAhmetDincerBlog.Models
{
    public class IletisimModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad alanı boş geçilemez!"), StringLength(50)]
        public string IsimSoyisim { get; set; }
        [Required(ErrorMessage = "Email alanı boş geçilemez!"), StringLength(50)]
        [EmailAddress(ErrorMessage = "Geçersiz Mail!")]
        public string Eposta { get; set; }
        [Display(Name = "Şifre"), DataType(DataType.Password)] // Şifre inputunun türü password olsun
        [Required(ErrorMessage = "{0} alanı boş geçilemez!"), StringLength(50)]
        public string Sifre { get; set; }

        [Display(Name = "Şifrenizi Tekrar Giriniz"), DataType(DataType.Password)]
        [Required(ErrorMessage = "{0} alanı boş geçilemez!"), StringLength(50)]
        [Compare("Sifre")] // SifreTekrar alanını Sifre alanıyla karşılaştır
        public string SifreTekrar { get; set; }
    }
}

