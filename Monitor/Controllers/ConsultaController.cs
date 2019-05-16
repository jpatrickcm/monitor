using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Monitor.Controllers
{
    public class ConsultaController : Controller
    {
        // GET: Consulta
        public ActionResult Index()
        {
            ViewBag.Consulta1 = new List<Monitor.Models.COMPROBANTES_FRP>().ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Index(object registroUsuarioobjPruebas)

        {
            var data = Conexiones.Conection.EjemploMetodo("esuiteCENTENARIO","2019-03-01","2019-05-01").ToList();
            ViewBag.Consulta1 = data;
            return RedirectToAction("Index", "Consulta");
        }
    }
}
