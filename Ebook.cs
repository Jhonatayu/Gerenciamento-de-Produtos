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
    class Ebook : Produto
    {
        public string Autor { get; set; }
        private int Vendas { get; set; }
        public string Tipo => "Ebook";

        public Ebook(string Nome, string Autor, float Preco)
        {
            this.Nome = Nome;
            this.Autor = Autor;
            this.Preco = Preco;
            this.Vendas = 0;
        }


    }
}
