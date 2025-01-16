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
    class Curso : Produto, IEstoque
    {
        public string Autor { get; set; }
        private int Vendas { get; set; }
        private int Vagas { get; set; }
        public string Tipo => "Curso";
        public Curso(string Id, string Nome, string Autor, float Preco)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Preco = Preco;
            this.Autor = Autor;
            this.Vagas = Vagas;
        }

        public void AdicionarEntrada()
        {
        }

        public void AdicionarSaida()
        {
        }
    }
}
