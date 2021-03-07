using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudoPedidos.Domain
{
    public abstract class BaseDomain
    {
        public int Id { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}
