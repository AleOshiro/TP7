using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP7.Models;

namespace TP7.Controllers
{
    public class FacturasController : Controller
    {
        Context context = new Context();

        // GET: Facturas
        public ActionResult Index()
        {
            return View();
        }

        // Listado de Facturas
        public ActionResult ListarFacturas()
        {
            return View(context.Factura.ToList());
        }

        // Cargar una factura
        public ActionResult CargarFactura()
        {
            return View();
        }

        // Cargar una factura
        [HttpPost]
        public ActionResult CargarFactura(FacturasModels factura)
        {
            context.Factura.Add(factura);
            context.SaveChanges();
            return RedirectToAction("ListarFacturas", "Facturas");
        }

        // Ver la factura a editar
        public ActionResult EditarFactura(int id = 0)
        {
            FacturasModels factura = context.Factura.Find(id);
            if (factura == null)
            {
                return HttpNotFound();
            }
            return View(factura);
        }

        // Editar factura
        [HttpPost]
        public ActionResult EditarFactura(FacturasModels factura)
        {
            context.Entry(factura).State = EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("ListarFacturas", "Facturas");
        }

        // Ver la factura a eliminar
        public ActionResult EliminarFactura(int id = 0)
        {
            FacturasModels factura = context.Factura.Find(id);
            if (factura == null)
            {
                return HttpNotFound();
            }
            return View(factura);
        }

        // Eliminar factura
        [HttpPost, ActionName("EliminarFactura")]
        public ActionResult Eliminar(int id = 0)
        {
            FacturasModels factura = context.Factura.Find(id);
            context.Factura.Remove(factura);
            context.SaveChanges();
            return RedirectToAction("ListarFacturas", "Facturas");
        }
    }
}