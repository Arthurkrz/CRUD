using CRUD.Repository;
using CRUD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.Service
{
    internal class ServiceCliente
    {
        private RepositoryCliente _repositorioCliente;
        public void Add(Cliente cliente)
        {
            if (Valid(cliente))
            {
                _repositorioCliente = new RepositoryCliente();
                _repositorioCliente.Add(cliente);
            }
            else
            {
                Console.WriteLine("Ocorreu um erro.");
            }
        }
        public List<Cliente> Listar()
        {
            _repositorioCliente = new RepositoryCliente();
            return _repositorioCliente.Listar();
        }
        public void Delete(Cliente cliente)
        {
            _repositorioCliente = new RepositoryCliente();
            _repositorioCliente.Delete(cliente);
        }
        public void Update(Cliente cliente)
        {
            _repositorioCliente = new RepositoryCliente();
            _repositorioCliente.Update(cliente);
        }
        private bool Valid(Cliente cliente)
        {
            if (cliente == null)
            {
                return false;
            }
            else if (!String.IsNullOrWhiteSpace(cliente.Nome) && !String.IsNullOrWhiteSpace(cliente.Email) && cliente.DataNascimento != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
