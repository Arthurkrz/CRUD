﻿using CRUD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.Controller
{
    internal class ControllerCliente
    {
        public bool CheckAdd(string nome, string email, DateTime dataNascimento)
        {
            if (!String.IsNullOrWhiteSpace(nome) && !String.IsNullOrWhiteSpace(email) && dataNascimento != null)
            {
                Cliente cliente = new Cliente()
                {
                    Nome = nome,
                    Email = email,
                    DataNascimento = dataNascimento
                };
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
