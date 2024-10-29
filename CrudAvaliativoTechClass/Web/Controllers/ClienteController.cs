﻿using CrudAvaliativoTechClass.Core.Contratos;
using CrudAvaliativoTechClass.Core.Entidades;
using System;

namespace CrudAvaliativoTechClass.Web.Controllers
{
    internal class ClienteController
    {
        private readonly IClienteSevice _clienteService;

        public ClienteController(IClienteSevice clienteSevice)
        {
            _clienteService = clienteSevice;
        }

        public void AdicionaCliente(string nome, DateTime nascimento, string email, int telefone)
        {

            Cliente cliente = new Cliente(nome, nascimento, email, telefone);
            _clienteService.AdicionarCliente(cliente);
        }
    }
}
