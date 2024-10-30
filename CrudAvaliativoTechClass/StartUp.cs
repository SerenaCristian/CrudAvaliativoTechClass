using CrudAvaliativoTechClass.Core.Contratos;
using CrudAvaliativoTechClass.Infra.Repositorios;
using CrudAvaliativoTechClass.Web.Services;
using Microsoft.Extensions.DependencyInjection;
namespace CrudAvaliativoTechClass
{
    internal class StartUp
    {
        public void InjetaDependencia()
        {
            ServiceCollection services = new ServiceCollection();
            services.AddScoped<IClienteRepositorio, ClienteRepositorio>();
            services.AddScoped<IClienteSevice, ClienteService>();
        }
    }
}
