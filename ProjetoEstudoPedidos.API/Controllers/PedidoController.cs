using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEstudoPedidos.API.Controllers
{

    public class AppBasePedidoController : AppBaseController
    {
        public AppBasePedidoController(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

    }
}
