using CrudAvaliativoTechClass.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CrudAvaliativoTechClass.Infra.Repositorios
{
    internal class ClienteRepositorio
    {
        private static List<Cliente> clientes = new List<Cliente>();
        private static int id = 0;

        public void AdicionarCliente(Cliente cliente)
        {
            
            var clienteExistente = clientes.FirstOrDefault(x => x.Email == cliente.Email);
            if (clienteExistente != null)
            {
                Console.WriteLine("Usuário já cadastrado");
                return;
            }

            cliente.Id = id++;
            clientes.Add(cliente);
        }

        public void Atualizar(Cliente cliente)
        {
            var atualizarCliente = clientes.FirstOrDefault(x => x.Id == cliente.Id);

            if (atualizarCliente != null)
            {
                atualizarCliente.Nome = cliente.Nome;
                atualizarCliente.Email = cliente.Email;
                atualizarCliente.Telefone = cliente.Telefone;
                atualizarCliente.DataNascimento = cliente.DataNascimento;
            }
            else
            {
                Console.WriteLine("Cliente não encontrado para atualização.");
            }
        }

        public void DeleteFisico(Cliente cliente)
        {
            clientes.Remove(cliente);
        }

        public List<Cliente> GetClientes()
        {
            return clientes;
        }
    }
}


