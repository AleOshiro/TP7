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

        public object Diagnostic { get; private set; }

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
            var factura = new FacturasModels();
            factura.Detalle.Add(new DetallesModels());
            factura.Detalle.Add(new DetallesModels());
            factura.Detalle.Add(new DetallesModels());
            factura.Detalle.Add(new DetallesModels());
            factura.Detalle.Add(new DetallesModels());
            return View(factura);
        }

        // Cargar una factura
        [HttpPost]
        public ActionResult CargarFactura(FacturasModels factura)
        {
            factura.Detalle.ForEach(detalle => {
                detalle.Precio = context.Articulo.Find(detalle.ArtciulosId).Precio * detalle.Cantidad;
                factura.Total += detalle.Precio;
            });
            context.Factura.Add(factura);
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

        // Listado de Detalles
        public ActionResult ListarDetalles()
        {
            return View(context.Detalle.ToList());
        }

        // Mostrar un detalle
        public ActionResult MostrarDetalle(int id = 0)
        {
            FacturasModels fac = context.Factura.Find(id);
            List<DetallesModels> listaDetalles = context.Detalle.Where(model => model.FacturaId == id).ToList();
            return View(listaDetalles);
        }
    
    }
}
