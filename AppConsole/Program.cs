using System;
using ClasesParcial3;
using ClasesParcial3.Models;
using ClasesParcial3.Data;
using ClasesParcial3.Repositories;
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
       ProductoRepository.RegistrarProducto();

    }
    if (Opcion == 2)
    {
        ClienteRepository.RegistrarCliente();
    }
    if (Opcion == 3)
    {
        VentaRepository.RegistrarVenta();
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