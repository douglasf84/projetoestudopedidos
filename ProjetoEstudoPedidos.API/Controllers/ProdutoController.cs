using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjetoEstudoPedidos.Domain;
using ProjetoEstudoPedidos.Interface;
using ProjetoEstudoPedidos.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEstudoPedidos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BaseController : AppBaseController
    {

        public BaseController(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        [HttpGet]
        public IEnumerable<Produto> Get()
        {
            var rep = (IProdutoRepository)ServiceProvider.GetService(typeof(IProdutoRepository));
            return rep.Get();
        }

        [HttpGet]
        [Route("search/{text}/{pagina?}")]
        public dynamic GetSearch(string text, int pagina = 1)
        {
            var rep = (IProdutoRepository)ServiceProvider.GetService(typeof(IProdutoRepository));
            return rep.Search(text, pagina);
        }

        [HttpGet]
        [Route("{id}")]
        public Produto Detail(int? id)
        {
            if ((id ?? 0) > 0)
            {
                var rep = (IProdutoRepository)ServiceProvider.GetService(typeof(IProdutoRepository));
                return rep.Detail(id.Value);
            }
            else
            {
                return null;
            }

        }


    }
}
