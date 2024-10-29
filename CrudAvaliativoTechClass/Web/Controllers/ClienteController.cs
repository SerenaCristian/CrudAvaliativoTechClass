using CrudAvaliativoTechClass.Core.Entidades;
using CrudAvaliativoTechClass.Web.Services;
using System;

namespace CrudAvaliativoTechClass.Web.Controllers
{
    internal class ClienteController
    {
        private readonly ClienteService _clienteService;

       
        public ClienteController(ClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        
        public void AdicionaCliente(string nome, DateTime nascimento, string email, int telefone)
        {
            
            Cliente cliente = new Cliente(nome, nascimento, email, telefone);

            
            _clienteService.AdicionarCliente(cliente);
        }
    }
}
