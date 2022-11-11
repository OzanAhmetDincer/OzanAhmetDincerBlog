using Microsoft.AspNetCore.Mvc;

namespace OzanAhmetDincerBlog.Controllers
{
    public class IletisimController : Controller
    {
        [HttpPost]
        public IActionResult Index(IFormCollection collections)
        {
            ViewBag.Name = collections["_name"];
            ViewBag.Email = collections["email"];
            ViewBag.Mesaj = collections["mesaj"];
            ViewBag.flexRadioDefault = collections["flexRadioDefault"];
            ViewBag.Check = collections["kontrol"][0];


            return View();
        }

        public IActionResult Index()
        {

            return View();
        }
    }
}
