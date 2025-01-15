using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Produtos
{
    class Ebook : Produto, IEstoque
    {
        public string Autor { get; set; }
        public int Vendas { get; set; }

        public Ebook(string Id, string Nome, float Preco, string Autor, int Vendas)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Preco = Preco;
            this.Autor = Autor;
            this.Vendas = Vendas;
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
