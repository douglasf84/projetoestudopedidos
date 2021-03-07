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

    }
}
