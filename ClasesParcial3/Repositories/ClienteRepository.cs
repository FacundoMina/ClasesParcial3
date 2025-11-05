using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesParcial3.Models;

namespace ClasesParcial3.Repositories
{
    public class ClienteRepository
    {
        public static void RegistrarCliente(Models.Cliente cliente)
        {
            using (var context = new Data.AplicationDbContext())
            {
                Console.WriteLine("Ingrese Nombre del Cliente");
                string nombreCliente = Console.ReadLine();
                Console.WriteLine("Ingrese Email del Cliente");
                string emailCliente = Console.ReadLine();
                Console.WriteLine("Ingrese CUIT del Cliente");
                int cuitCliente = int.Parse(Console.ReadLine());
                cliente = new Models.Cliente
                {
                    Nombre = nombreCliente,
                    Email = emailCliente,
                    CUIT = cuitCliente
                };
                context.Cliente.Add(cliente);
                context.SaveChanges();

            }
        }
    }
}
