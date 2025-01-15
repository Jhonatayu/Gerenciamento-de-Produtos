using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Produtos
{
    class ProdutoFisico : Produto, IEstoque
    {
        private int Quantidade { get; set; }

        public ProdutoFisico(string Id, string Nome, float Preco, int Quantidade)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Preco = Preco;
            this.Quantidade = Quantidade;
        }

        public void Exibir()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Preço: {Preco}");
            Console.WriteLine($"Quantidade em Estoque: {Quantidade}");
            Console.WriteLine($"\n- - - - - - - - - - - - - - - - - - - - - - - - - - -\n");
        }

        public void AdicionarEntrada()
        {
        }

        public void AdicionarSaida()
        {
        }
    }
}
