using Microsoft.Extensions.DependencyInjection;

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
        }
    }
}
