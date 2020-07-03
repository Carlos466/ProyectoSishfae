using SishFae.Models;
using System.Web.Mvc;

namespace SishFae.Controllers
{
    public class AreaController : Controller
    {
        // GET: Area
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Crear()
        {
            Areas Area = new Areas();
            return View(Area);
        }
        [HttpPost]
        public ActionResult Crear(Areas Area)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Areas");
            }

            return View(Area);
        }
        public ActionResult Ver()
        {
            return View();
        }

        public ActionResult Editar()
        {
            return View();
        }
    }
}