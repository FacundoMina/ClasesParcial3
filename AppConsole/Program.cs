using System;
using ClasesParcial3;
using ClasesParcial3.Models;
using ClasesParcial3.Data;
using ClasesParcial3.Repositories;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Infrastructure;
do
{
    Console.WriteLine("===============================");
    Console.WriteLine("\tBienvenido al Menu");
    Console.WriteLine("===============================");
    Console.WriteLine();
    Console.WriteLine("Escoge una de las siguientes opciones");
    Console.WriteLine();
    Console.WriteLine("\t1.Registrar Nuevo Producto");
    Console.WriteLine("\t2.Registrar Nuevo Cliente");
    Console.WriteLine("\t3.Registrar Venta");
    Console.WriteLine("\t4.Mostrar Reporte de Ventas");
    Console.WriteLine("\t5.Salir");
    
    int Opcion = int.Parse(Console.ReadLine());
    Console.Clear();
    if (Opcion == 1)
    {
        
        Console.Write("Ingrese el nombre del producto: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese el precio del producto: ");
        decimal precio = decimal.Parse(Console.ReadLine());

        Console.Write("Ingrese la cantidad en stock: ");
        int stock = int.Parse(Console.ReadLine());

        
        var producto = new Producto
        {
            Nombre = nombre,
            Precio = precio,
            Stock = stock
        };

        
        ProductoRepository.RegistrarProducto(producto);
    }
    if (Opcion == 2)
    {
        Console.Write("Ingrese el nombre del cliente: ");
        string nombreCliente = Console.ReadLine();

        Console.Write("Ingrese el correo del cliente: ");
        string correoCliente = Console.ReadLine();

        
        var cliente = new Cliente
        {
            Nombre = nombreCliente,
            
        };

        ClienteRepository.RegistrarCliente(cliente);
    }
    if (Opcion == 3)
    {
        
        Console.Write("Ingrese el ID del cliente: ");
        int clienteId = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el ID del producto: ");
        int productoId = int.Parse(Console.ReadLine());

        Console.Write("Ingrese la cantidad: ");
        int cantidad = int.Parse(Console.ReadLine());

        Cliente cliente = ClienteRepository.ObtenerClientePorId(clienteId);
        Producto producto = ProductoRepository.ObtenerProductoPorId(productoId);

        
        double precioVenta = (double)(producto.Precio * cantidad);

       
        List<Venta> ventas = new List<Venta>();

        
        var venta = new Venta(0, cliente, producto, precioVenta, ventas);

        VentaRepository.RegistrarVenta(venta);
    }
    if (Opcion == 4)
    {
        VentaRepository.MostrarVentas();
    } 
    if (Opcion == 5)
    {
        break;
    }

} while (true);