using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

namespace Gerenciamento_de_Produtos
{
    class Ebook : Produto, IEstoque
    {
        public string Autor { get; set; }
        private int Vendas { get; set; }

        public Ebook(string Id, string Nome, string Autor, float Preco)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Autor = Autor;
            this.Preco = Preco;
            this.Vendas = 0;
        }

        public void Exibir()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Preço: {Preco}");
            Console.WriteLine($"Vendas: {Vendas}");
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
