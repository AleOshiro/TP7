using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP7.Models;

namespace TP7.Controllers
{
    public class ArticulosController : Controller
    {
        Context context = new Context();

        // GET: Articulos
        public ActionResult Index()
        {
            return View();
        }

        // Listado de Articulos
        public ActionResult ListarArticulos()
        {
            /*
            List<ArticulosModels> listadoDeArticulos = new List<ArticulosModels> {
                new ArticulosModels("Hel1", "Heladera", 23000),
                new ArticulosModels("Mic1", "Microondas", 5000),
                new ArticulosModels("Tev1", "Televisor", 10000),
                new ArticulosModels("Tev2", "Televisor", 10000)
            };

            foreach (ArticulosModels articulos in listadoDeArticulos) 
               context.Articulo.Add(articulos);
            context.SaveChanges();
            */

            return View(context.Articulo.ToList());
        }

        // Cargar un articulo
        public ActionResult CargarArticulo()
        {
            return View();
        }

        // Cargar un articulo
        [HttpPost]
        public ActionResult CargarArticulo(ArticulosModels articulo)
        {
            context.Articulo.Add(articulo);
            context.SaveChanges();
            return RedirectToAction("ListarArticulos", "Articulos");
        }

        // Ver el articulo a editar
        public ActionResult EditarArticulo(int id = 0)
        {
            ArticulosModels art = context.Articulo.Find(id);
            if (art == null)
            {
                return HttpNotFound();
            }
            return View(art);
        }

        // Editar el articulo
        [HttpPost]
        public ActionResult EditarArticulo(ArticulosModels articulo)
        {
            context.Entry(articulo).State = EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("ListarArticulos", "Articulos");
        }

        // Ver el articulo a eliminar
        public ActionResult EliminarArticulo(int id = 0)
        {
            ArticulosModels articulo = context.Articulo.Find(id);
            if (articulo == null)
            {
                return HttpNotFound();
            }
            return View(articulo);
        }

        // Eliminar articulo
        [HttpPost, ActionName("EliminarArticulo")]
        public ActionResult Eliminar(int id = 0)
        {
            ArticulosModels articulo = context.Articulo.Find(id);
            context.Articulo.Remove(articulo);
            context.SaveChanges();
            return RedirectToAction("ListarArticulos", "Articulos");
        }
    }
}