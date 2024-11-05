using CrudAvaliativoTechClass.Core.Contratos;
using CrudAvaliativoTechClass.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CrudAvaliativoTechClass.Servico
{
    internal class EnderecoService : IEnderecoService
    {
        private readonly IEnderecoService _enderecoRepositorio;

        public EnderecoService(IEnderecoService enderecoRepositorio)
        {
            _enderecoRepositorio = enderecoRepositorio;
        }

        public EnderecoCliente GetEnderecoCliente()
        {
            return new EnderecoCliente("Rua XXXX", 195);
        }

        public void AdicionarCliente(EnderecoCliente endereco)
        {
            if (!ValidarEndereco(endereco))
            {
                Console.WriteLine("Erro ao adicionar cliente: dados inválidos.");
                return;
            }

            _enderecoRepositorio.AdicionarEndereco(endereco);
        }

        public List<EnderecoCliente> TodosEnderecos()
        {
            Console.WriteLine("Obtendo lista de endereços ativos...");
            return _enderecoRepositorio.GetEnderecos();
        }

        public void EditarEndereco(int enderecoId, string novoEndereco, int novoNumero)
        {
            var endereco = _enderecoRepositorio.GetEnderecos().FirstOrDefault(c => c.Id == enderecoId);
            if (endereco != null)
            {
                endereco.Endereco = novoEndereco;
                endereco.Numero = novoNumero;
                _enderecoRepositorio.Atualizar(endereco);
            }
            else
            {
                Console.WriteLine("Endereço não encontrado.");
            }
        }

        public void ExcluirEnderecoFisicamente(int enderecoId)
        {
            var endereco = _enderecoRepositorio.GetEnderecos().FirstOrDefault(c => c.Id == enderecoId);
            if (endereco != null)
            {
                _enderecoRepositorio.DeleteFisico(endereco);
            }
            else
            {
                Console.WriteLine("Endereço não encontrado para exclusão.");
            }
        }

        private bool ValidarEndereco(EnderecoCliente enderecoCliente)
        {
            return enderecoCliente != null &&
                   !string.IsNullOrWhiteSpace(enderecoCliente.Endereco) &&
                   enderecoCliente.Numero > 0;
        }

        
        public void AdicionarEndereco(EnderecoCliente endereco)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(EnderecoCliente endereco)
        {
            throw new NotImplementedException();
        }

        public void DeleteFisico(EnderecoCliente endereco)
        {
            throw new NotImplementedException();
        }

        public List<EnderecoCliente> GetEnderecos()
        {
            throw new NotImplementedException();
        }
    }
}
