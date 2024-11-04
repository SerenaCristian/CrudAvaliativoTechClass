using CrudAvaliativoTechClass.Core.Entidades;
using System.Collections.Generic;

namespace CrudAvaliativoTechClass.Core.Contratos
{
    internal interface IEnderecoService
    {
        void AdicionarEndereco(EnderecoCliente endereco);
        void Atualizar(EnderecoCliente endereco);
        void DeleteFisico(EnderecoCliente endereco);
        List<EnderecoCliente> GetEnderecos();
    }
}
