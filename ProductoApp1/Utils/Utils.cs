using ProductoApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductoApp1.Utils
{
    internal class Utils
    {
        static public List<Producto> ListaProductos = new List<Producto>()
        {
            new Producto{
                IdProducto=1,
                Nombre="Producto 1",
                Descripcion="Descripcion 1",
                cantidad=1
            },

            new Producto{
                IdProducto=2,
                Nombre = "Producto 2",
                Descripcion="Descripcion 2",
                cantidad=2
            },

             new Producto{
                IdProducto=3,
                Nombre = "Producto 3000",
                Descripcion="Descripcion 3000",
                cantidad=400
            }


        };

    }
}
