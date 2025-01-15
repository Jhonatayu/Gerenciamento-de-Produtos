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
    abstract class Produto
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
    }
}
