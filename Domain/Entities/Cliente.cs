using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.Domain.Entities
{
    class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Ativo { get; set; }
        public string Email { get; set; }
        public Cliente()
        {
            Ativo = true;
        }
    }
}
