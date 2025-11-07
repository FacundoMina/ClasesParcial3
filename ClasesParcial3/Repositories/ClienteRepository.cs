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
        public static void RegistrarCliente(Cliente cliente)
        {
            using (var context = new Data.AplicationDbContext())
            {
                
                context.Cliente.Add(cliente);
                context.SaveChanges();

            }
        }
        public static Cliente ObtenerClientePorId(int id)
        {
            using (var context = new Data.AplicationDbContext())
            {
                var cliente = context.Cliente.Find(id);
                return cliente;
            }
        }
    }
}
