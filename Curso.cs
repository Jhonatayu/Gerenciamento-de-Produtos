using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Produtos
{
    class Curso : Produto, IEstoque
    {
        public string Autor { get; set; }
        public int Vendas { get; set; }
        public int Vagas { get; set; }
        public Curso(string Id, string Nome, float Preco, string Autor, int Vendas, int vagas)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Preco = Preco;
            this.Autor = Autor;
            this.Vendas = Vendas;
            this.Vagas = Vagas;
        }
}
