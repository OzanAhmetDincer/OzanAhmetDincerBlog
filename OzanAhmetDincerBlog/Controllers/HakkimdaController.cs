using Microsoft.AspNetCore.Mvc;

namespace OzanAhmetDincerBlog.Controllers
{
    public class HakkimdaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
