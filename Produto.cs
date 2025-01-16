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
    [System.Serializable]
    class Produto
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string Tipo {  get; set; }
        public float Preco { get; set; }
        public int Quantidade {  get; set; }
        public int Vendas {get; set; }
        public int Vagas {get; set; }
        
    }
}
