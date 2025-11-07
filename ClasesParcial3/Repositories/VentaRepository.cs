using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesParcial3.Repositories
{
    public class VentaRepository
    {
        public static void RegistrarVenta(Models.Venta venta)
        {
            using (var context = new Data.AplicationDbContext())
            {
                Console.WriteLine("Ingrese ID del Cliente");
                int idCliente = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese ID del Producto");
                int idProducto = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese Precio de Venta");
                double precioVenta = double.Parse(Console.ReadLine());

                
                var cliente = context.Cliente.Find(idCliente);
                var producto = context.Producto.Find(idProducto);

                if (cliente == null || producto == null)
                {
                    Console.WriteLine("Cliente o Producto no encontrado.");
                    return;
                }

                venta = new Models.Venta(
                    0,
                    cliente,
                    producto,
                    precioVenta,
                    new List<Models.Venta>() 
                );

                context.Venta.Add(venta);
                context.SaveChanges();
            }
        }

        public static void MostrarVentas()
        {
            using (var context = new Data.AplicationDbContext())
            {
                var ventas = context.Venta
                    .Select(v => new
                    {
                        v.Id,
                        ClienteNombre = v.IdCliente.Nombre,
                        ProductoNombre = v.IdProducto.Nombre,
                        v.PrecioVenta
                    })
                    .ToList();
                foreach (var v in ventas)
                {
                    Console.WriteLine($"ID Venta: {v.Id}, Cliente: {v.ClienteNombre}, Producto: {v.ProductoNombre}, Precio Venta: {v.PrecioVenta}");
                }
            }

        }
    }

    
}
