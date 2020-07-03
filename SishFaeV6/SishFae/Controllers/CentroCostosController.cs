using SishFae.Models;
using System.Web.Mvc;

namespace SishFae.Controllers
{
    public class CentroCostosController : Controller
    {
        // GET: CentroCosto
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Crear()
        {
            CentroCosto centrocosto = new CentroCosto();

            return View(centrocosto);
        }

        [HttpPost]
        public ActionResult Crear(CentroCosto centrocosto)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "CentroCostos");
            }
            return View(centrocosto);
        }

        public ActionResult AsignacionTareaCentrocosto()
        {
            return View();
        }
    }
}