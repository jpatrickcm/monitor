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
            //var data = Conexiones.Conection.EjemploMetodo("esuiteCENTENARIO","2019-03-01","2019-05-01").ToList();

            List<Monitor.Models.COMPROBANTES_FRP> listado = new List<Monitor.Models.COMPROBANTES_FRP>().ToList();
            Monitor.Models.COMPROBANTES_FRP objeto = new Models.COMPROBANTES_FRP();
            objeto.RUC = "20510675411";
            objeto.COMPROBANTE = "2415";
            objeto.CORRELATIVO = Int32.Parse("33331");
            objeto.SERIE = "B001";
            objeto.FECHA_CARGA = "2019-01-01";
            objeto.FECHA_EMISION = "2019-01-01";
            objeto.MENSAJE = "HOLIII";
            objeto.NUMERO_EMPRESA = Int32.Parse("2222222");
            objeto.ESTADO = "ERR";
            listado.Add(objeto);
            var data = listado;

            ViewBag.Consulta1 = data;
            return View();
            //return RedirectToAction("Index", "Consulta");
        }
    }
}
