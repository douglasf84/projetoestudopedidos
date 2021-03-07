
using System.Collections.Generic;

namespace ProjetoEstudoPedidos.Domain
{
    public class Cliente : BaseDomain, IExibivel
    {
        public string Nome { get; set; }

        public string Cpf { get; set; }
        public int IdEndereco { get; set; }
        public virtual Endereco Endereco { get; set; }

        public bool Ativo { get; set; }

        public List<Pedido> Pedidos { get; set; }


    }
}
