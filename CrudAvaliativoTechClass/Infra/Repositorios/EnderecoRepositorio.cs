using CrudAvaliativoTechClass.Core.Entidades;
using System.Collections.Generic;
using System;
using System.Linq;

namespace CrudAvaliativoTechClass.Infra.Repositorios
{
    internal class EnderecoRepositorio
    {
        private static List<EnderecoCliente> enderecos = new List<EnderecoCliente>();
        private static int id = 0;

        public void AdicionarEndereco(EnderecoCliente endereco)
        {
            var enderecoExistente = enderecos.FirstOrDefault(x => x == endereco);
            if (enderecoExistente != null)
            {
                Console.WriteLine("Endereço já cadastrado.");
                return;
            }

            endereco.Id = id++;
            enderecos.Add(endereco);
        }

        public void Atualizar(EnderecoCliente endereco)
        {
            var atualizarEndereco = enderecos.FirstOrDefault(x => x.Id == endereco.Id);

            if (atualizarEndereco != null)
            {
                atualizarEndereco.Endereco = endereco.Endereco;
                atualizarEndereco.Numero = endereco.Numero;
                
            }
            else
            {
                Console.WriteLine("Endereço não encontrado para atualização.");
            }
        }

        public void DeleteFisico(EnderecoCliente endereco)
        {
            enderecos.Remove(endereco);
        }

        public List<EnderecoCliente> GetEnderecos()
        {
            return enderecos;
        }
    }
}
