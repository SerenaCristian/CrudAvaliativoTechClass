using CrudAvaliativoTechClass.Core.Entidades;
using CrudAvaliativoTechClass.Infra.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CrudAvaliativoTechClass.Web.Services
{
    internal class ClienteService
    {
        private readonly ClienteRepositorio _clienteRepositorio;

        
        public ClienteService(ClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public ClienteService()
        {
        }

        public void AdicionarCliente(Cliente cliente)
        {
            if (!ValidarCliente(cliente))
            {
                Console.WriteLine("Erro ao adicionar cliente: dados inválidos.");
                return;
            }

            _clienteRepositorio.AdicionarCliente(cliente);
        }


        public List<Cliente> TodosClientes()
        {
            Console.WriteLine("Obtendo lista de clientes ativos...");
            return _clienteRepositorio.GetClientes();
        }

      
        public void EditarCliente(int clienteId, string novoNome, string novoEmail, DateTime novaDataNascimento)
        {
            var cliente = _clienteRepositorio.GetClientes().FirstOrDefault(c => c.Id == clienteId);
            if (cliente != null)
            {
                cliente.Nome = novoNome;
                cliente.Email = novoEmail;
                cliente.DataNascimento = novaDataNascimento;
                _clienteRepositorio.Atualizar(cliente);
            }
            else
            {
                Console.WriteLine("Cliente não encontrado.");
            }
        }

        
        public void ExcluirClienteFisicamente(int clienteId)
        {
            var cliente = _clienteRepositorio.GetClientes().FirstOrDefault(c => c.Id == clienteId);
            if (cliente != null)
            {
                _clienteRepositorio.DeleteFisico(cliente);
            }
            else
            {
                Console.WriteLine("Cliente não encontrado para exclusão.");
            }
        }

        
        private bool ValidarCliente(Cliente cliente)
        {
            return cliente != null &&
                   !string.IsNullOrWhiteSpace(cliente.Nome) &&
                   !string.IsNullOrWhiteSpace(cliente.Email) &&
                   cliente.DataNascimento != DateTime.MinValue;
        }
    }
}
