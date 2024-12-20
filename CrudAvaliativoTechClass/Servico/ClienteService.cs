﻿using CrudAvaliativoTechClass.Core.Contratos;
using CrudAvaliativoTechClass.Core.Entidades;
using CrudAvaliativoTechClass.Infra.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CrudAvaliativoTechClass.Web.Services
{
    internal class ClienteService: IClienteSevice
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        
        public ClienteService(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public Cliente GetCliente()
        {
            return new Cliente("Nome", new DateTime(), "teste@teste", 99999);
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

        public void Atualizar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void AtualizarCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void DeleteCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void GetClientes(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
