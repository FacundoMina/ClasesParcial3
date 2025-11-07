using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesParcial3.Data;
using ClasesParcial3.Models;

namespace ClasesParcial3.Repositories
{
    public class ProductoRepository
    {
        public static void RegistrarProducto(Producto producto)
        {
            using (var context = new AplicationDbContext())
            {
                context.Producto.Add(producto);
                context.SaveChanges();
            }


        }
        public static Producto ObtenerProductoPorId(int id)
        {
            using (var context = new AplicationDbContext())
            {
                var producto = context.Producto.Find(id);
                if (producto != null)
                {
                    return producto;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
