using CrudAvaliativoTechClass.Core.Entidades;
using System.Collections.Generic;

namespace CrudAvaliativoTechClass.Core.Contratos
{
    internal interface IClienteRepositorio
    {
        void AdicionarCliente(Cliente cliente);
        void Atualizar(Cliente cliente);
        void DeleteFisico(Cliente cliente);
        List<Cliente> GetClientes();
    }
}
