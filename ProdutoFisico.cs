using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Produtos
{
    class ProdutoFisico : Produto, IEstoque
    {
        public int Quantidade { get; set; }

        public ProdutoFisico(string Id, string Nome, float Preco, int Quantidade)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Preco = Preco;
            this.Quantidade = Quantidade;
        }

        public void Exibir()
        {
        }

        public void AdicionarEntrada()
        {
        }

        public void AdicionarSaida()
        {
        }
    }
}
