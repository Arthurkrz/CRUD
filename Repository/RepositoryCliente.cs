using CRUD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUD.Repository
{
    internal class RepositoryCliente
    {
        private static List<Cliente> clientes = new List<Cliente>();
        private static int id = 0;
        public void Add(Cliente cliente)
        {
            cliente.Id = id++;
            clientes.Add(cliente);
        }
        public void Update(Cliente cliente)
        {
            Cliente banco = clientes.FirstOrDefault(x => x.Id == cliente.Id); // não entendi essa linha :(
        }
        public void Delete(Cliente cliente)
        {
            clientes.Remove(cliente);
        }
        public List<Cliente> Listar()
        {
            return clientes;
        }
    }
}
