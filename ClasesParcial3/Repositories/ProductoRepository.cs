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
            Console.WriteLine("Ingrese Nombre del Producto");
            string nombreProducto = Console.ReadLine();
            Console.WriteLine("Ingrese ID del Producto");
            int idProducto = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Precio del Producto");
            decimal precioProducto = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Stock del Producto");
            int stockProducto = int.Parse(Console.ReadLine());

            Producto nuevoProducto = new Producto
            {
                Id = idProducto,
                Nombre = nombreProducto,
                Precio = precioProducto,
                Stock = stockProducto
            };

            RegistrarProducto(nuevoProducto);

        }
    }
}
