using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesParcial3.Models
{
    public class Venta
    {
        public int Id { get; set; }
        public Cliente IdCliente { get; set; }
        public Producto IdProducto { get; set; }
        public double PrecioVenta { get; set; }
        public List<Venta> Ventas { get; set; } = new List<Venta>();

       public Venta(int id, Cliente idCliente, Producto idProducto, double precioVenta, List<Venta> ventas)
        {
            Id = id;
            IdCliente = idCliente;
            IdProducto = idProducto;
            PrecioVenta = precioVenta;
            Ventas = ventas;
        }
    }
}
