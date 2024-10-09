using CRUD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.Repository
{
    internal abstract class RepositoryBase
    {
        public abstract void Add(Cliente cliente);
        public abstract void Delete(Cliente cliente);
        public abstract void Update(Cliente cliente);
        public abstract List<Cliente> Listar(Cliente cliente);
    }
}
