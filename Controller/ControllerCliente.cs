using CRUD.Service;
using CRUD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.Controller
{
    internal class ControllerCliente
    {
        private ServiceCliente _serviceCliente;
        public void Add(string nome, string email, DateTime dataNascimento, int id)
        {
            Cliente cliente = new Cliente()
            {
                Nome = nome,
                Email = email,
                DataNascimento = dataNascimento
            };
            _serviceCliente = new ServiceCliente();
            _serviceCliente.Add(cliente);
        }
        public List<Cliente> Listar()
        {
            _serviceCliente = new ServiceCliente();
            return _serviceCliente.Listar();
        }
        public void Delete(Cliente cliente)
        {
            _serviceCliente = new ServiceCliente();
            _serviceCliente.Delete(cliente);
        }
        public void Update(Cliente cliente)
        {
            _serviceCliente = new ServiceCliente();
            _serviceCliente.Update(cliente);
        }
    }
}
