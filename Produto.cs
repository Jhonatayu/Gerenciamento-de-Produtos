using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Runtime.CompilerServices;
using Gerenciamento_de_Produtos;

namespace Gerenciamento_de_Produtos
{
    [System.Serializable]
    class Produto : Program
    {
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string Tipo { get; set; }
        public float Preco { get; set; }
        public int Quantidade { get; set; }
        public int Vendas { get; set; }
        public int Vagas { get; set; }

    }
}