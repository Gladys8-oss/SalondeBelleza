using SalondeBelleza.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SalondeBelleza.web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var producto1 = new ProductoModel();
            producto1.Id = 1;
            producto1.Descripcion = "Plancha";

            var producto2 = new ProductoModel();
            producto2.Id = 2;
            producto2.Descripcion = "Labial";

            var producto3 = new ProductoModel();
            producto3.Id = 3;
            producto3.Descripcion = "Sombras";

            var ListadeProductos = new List<ProductoModel>();
            ListadeProductos.Add(producto1);
            ListadeProductos.Add(producto2);
            ListadeProductos.Add(producto3);

            return View(ListadeProductos);
        }
    }
}