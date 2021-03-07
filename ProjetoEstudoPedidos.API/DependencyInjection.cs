using Microsoft.Extensions.DependencyInjection;
using ProjetoEstudoPedidos.Interface;
using ProjetoEstudoPedidos.Repository;

namespace ProjetoEstudoPedidos.API
{
    public class DependencyInjection
    {
        public static void Register(IServiceCollection serviveProvider)
        {
            RepositoryDependence(serviveProvider);
        }

        public static void RepositoryDependence(IServiceCollection serviveProvider)
        {
            serviveProvider.AddScoped<IProdutoRepository, ProdutoRepository>();
        }
    }
}
