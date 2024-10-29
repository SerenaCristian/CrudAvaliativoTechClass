using CrudAvaliativoTechClass.Core.Contratos;
using CrudAvaliativoTechClass.Core.Entidades;
using CrudAvaliativoTechClass.Web.Services;
using System;

namespace CrudAvaliativoTechClass.Web.Controllers
{
    internal class ClienteController
    {
        private readonly IClienteSevice _clienteService;

       
        public ClienteController(ClienteService clienteService)
        {
            _clienteService = (IClienteSevice)clienteService;
        }

        
        public void AdicionaCliente(string nome, DateTime nascimento, string email, int telefone)
        {
            
            Cliente cliente = new Cliente(nome, nascimento, email, telefone);

            
            _clienteService.AdicionarCliente(cliente);
        }
    }
}
