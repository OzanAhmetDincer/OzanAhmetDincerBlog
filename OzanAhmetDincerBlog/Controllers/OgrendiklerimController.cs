using Microsoft.AspNetCore.Mvc;

namespace OzanAhmetDincerBlog.Controllers
{
    public class OgrendiklerimController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult HtmlView()
        {
            return View();
        }
        public IActionResult CssView()
        {
            return View();
        }
        public IActionResult JavaScriptView()
        {
            return View();
        }
    }
}
