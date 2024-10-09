using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.Domain.Entities
{
    public class Cliente
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public Cliente() { }
    }
}
