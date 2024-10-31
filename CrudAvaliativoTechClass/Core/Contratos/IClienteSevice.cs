using CrudAvaliativoTechClass.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrudAvaliativoTechClass.Core.Contratos
{
    internal interface IClienteSevice
    {
        void AdicionarCliente(Cliente cliente);
        void Atualizar(Cliente cliente);
        void AtualizarCliente(Cliente cliente);
        void DeleteCliente(Cliente cliente);
        void GetClientes(Cliente cliente);
    }
}
