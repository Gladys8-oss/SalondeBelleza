using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonDeBelleza.BL
{
    public class ProductosBL
    {
      public   List<Producto> ObtenerProductos()
        {
            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Plancha";
            producto1.Precio = 600;

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Labial";
            producto2.Precio = 200;

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "Sombras";
            producto3.Precio = 900;

            var ListadeProductos = new List<Producto>();
            ListadeProductos.Add(producto1);
            ListadeProductos.Add(producto2);
            ListadeProductos.Add(producto3);

            return ListadeProductos;
        }
    }
}
