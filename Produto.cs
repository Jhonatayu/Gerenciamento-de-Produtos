﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Produtos
{
    abstract class Produto
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
    }
}
