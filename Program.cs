﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using Newtonsoft.Json;
using System.Reflection.Metadata.Ecma335;

namespace Gerenciamento_de_Produtos
{
    internal class Program
    {
        static List<Produto> produtos = new List<Produto>();

        enum Menu {Sair, Listar, Adicionar, Editar, Remover, Entrada, Saida }
        enum MenuCadastro {Sair, ProdutoFisico, Ebook, Curso}

        static void Main(string[] args)
        {
            ProgramMenu();
        }

        static void ProgramMenu()
        {
            Clear();
            CarregarProdutos();
            Console.WriteLine("\t\tGerenciamento de Estoque");
            Console.WriteLine("\n1- Listar Produtos\n2- Adicionar Produto\n3- Editar Produto\n4- Remover Produto\n5- Entrada de Estoque\n6- Saída de Estoque\n0- Sair");
            Console.Write("\nSelecione uma opção: ");
            Menu opcao = (Menu)int.Parse(Console.ReadLine()); 

            switch (opcao)
            {
                case Menu.Listar:
                    ListarProdutos();
                    break;
                case Menu.Adicionar:
                    Cadastro();
                    break;
                case Menu.Editar:
                    Editar();
                    break;
                case Menu.Remover:
                    RemoverProduto();
                    break;
                case Menu.Entrada:
                    break;
                case Menu.Saida:
                    break;
                case Menu.Sair:
                    Clear();
                    Console.WriteLine("Muito obrigado por utilizar nossos serviços!");
                    Console.Write("\nPressione ENTER para sair do programa. ");
                    ReadLine();
                    break;
                default:
                    Clear();
                    Console.WriteLine("Por favor selecione uma opção válida.");
                    Console.Write("\nPressione ENTER para retornar ao Menu. ");
                    ReadLine();
                    ProgramMenu();
                    break;
            }
        }

        static void Cadastro()
        {
            Clear();
            Console.WriteLine("\t\tCadastro de Produto");
            Console.WriteLine("\n1- Cadastrar Produto Físico\n2- Cadastrar Ebook\n3- Cadastrar Curso\n0- Retornar ao Menu Principal");
            Console.Write("\nSelecione uma opção: ");
            MenuCadastro opcaoCadastro = (MenuCadastro)int.Parse(Console.ReadLine());

            switch (opcaoCadastro)
            {
                case MenuCadastro.ProdutoFisico:
                    CadastrarProdutoFisico();
                    break;
                case MenuCadastro.Ebook:
                    CadastrarEbook();
                    break;
                case MenuCadastro.Curso:
                    CadastrarCurso();
                    break;
                case MenuCadastro.Sair:
                    ProgramMenu();
                    break;
                default:
                    Clear();
                    Console.WriteLine("Por favor selecione uma opção válida.");
                    Console.Write("\nPressione ENTER para retornar ao menu. ");
                    ReadLine();
                    Cadastro();
                    break;
            }

        }

        static void CadastrarProdutoFisico()
        {
            Clear();
            Console.WriteLine("\t\tCadastro de Produto Físico");

            Console.Write("\nDigite o NOME do produto: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o PREÇO do produto: ");
            float preco = float.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade inicial do produto em estoque: ");
            int qtd = int.Parse(Console.ReadLine());

            Console.Write("\nDeseja alterar os dados? (sim/não) ");
            string alterar = Console.ReadLine().ToUpper();

            if (alterar == "SIM")
            {
                CadastrarProdutoFisico();

            }
            else if (alterar == "NÃO" || alterar == "NAO")
            {
                ProdutoFisico pf = new ProdutoFisico(nome, preco, qtd);
                produtos.Add(pf);
                SalvarProduto();
                Clear();
                Console.WriteLine("Produto Físico adicionado com sucesso! ");
                Console.Write("\nPressione ENTER para retornar ao menu.");
                ReadLine();
            }

            Cadastro();
        }

        static void CadastrarEbook()
        {
            Clear();
            Console.WriteLine("\t\tCadastro de Ebook");

            Console.Write("\nDigite o NOME do produto: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o nome do AUTOR: ");
            string autor = Console.ReadLine();

            Console.Write("Digite o PREÇO do produto: ");
            float preco = float.Parse(Console.ReadLine());

            Console.Write("\nDeseja alterar os dados? (sim/não) ");
            string alterar = Console.ReadLine().ToUpper();

            if (alterar == "SIM")
            {
                CadastrarEbook();

            }
            else if (alterar == "NÃO" || alterar == "NAO")
            {
                Ebook ebook = new Ebook(nome, autor, preco);
                produtos.Add(ebook);
                SalvarProduto();
                Clear();
                Console.WriteLine("Ebook adicionado com sucesso! ");
                Console.Write("\nPressione ENTER para retornar ao menu.");
                ReadLine();
            }

            Cadastro();
        }

        static void CadastrarCurso()
        {
            Clear();
            Console.WriteLine("\t\tCadastro de Curso");

            Console.Write("\nDigite o NOME do produto: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o nome do AUTOR: ");
            string autor = Console.ReadLine();

            Console.Write("Digite o PREÇO do produto: ");
            float preco = float.Parse(Console.ReadLine());

            Console.Write("\nDeseja alterar os dados? (sim/não) ");
            string alterar = Console.ReadLine().ToUpper();

            if (alterar == "SIM")
            {
                CadastrarCurso();

            }
            else if (alterar == "NÃO" || alterar == "NAO")
            {
                Curso curso = new Curso(nome, autor, preco);
                produtos.Add(curso);
                SalvarProduto();
                Clear();
                Console.WriteLine("Curso adicionado com sucesso! ");
                Console.Write("\nPressione ENTER para retornar ao menu.");
                ReadLine();
            }

            Cadastro();
        }

        static void SalvarProduto()
        {
            string json = JsonConvert.SerializeObject(produtos);
            File.WriteAllText("produtos.json", json);
        }

        static void CarregarProdutos()
        {
            if (File.Exists("produtos.json"))
            {
                var json = File.ReadAllText("produtos.json");
                if (!string.IsNullOrWhiteSpace(json))
                {
                    produtos = JsonConvert.DeserializeObject<List<Produto>>(json);

                }
            }
        }

        static void RemoverProduto()
        {
            Exibir();
            Console.Write("Selecione o ID do Produto que deseja remover: ");
            int id = int.Parse(Console.ReadLine());

            if (id < 0 || id > produtos.Count) 
            {
                Console.WriteLine("Por favor digite um ID válido. ");
                Console.Write("\nPressione ENTER para continuar. ");
                ReadLine();
                RemoverProduto();

            }else
            {
                produtos.RemoveAt(id);
                SalvarProduto();
            }

            Clear();
            Console.Write("Produto removido com sucesso! Deseja remover outro produto? (sim/não): ");
            string remover = Console.ReadLine().ToUpper();

            if (remover == "SIM") 
            {
                CarregarProdutos();
                RemoverProduto();

            }else if (remover == "NÃO" || remover == "NAO")
            {
                Console.Write("\nPressione ENTER para retornar ao menu. ");
                ReadLine();
                ProgramMenu();
            }

        }

        static void Exibir()
        {
            Clear();
            int i = 0;
            foreach (Produto produto in produtos)
            {
                switch (produto.Tipo)
                {
                    case "Produto Físico":
                        Console.WriteLine($"ID do Produto: {i}\n");
                        Console.WriteLine($"Tipo do Produto: {produto.Tipo}");
                        Console.WriteLine($"Nome do Produto: {produto.Nome}");
                        Console.WriteLine($"Preço do Produto: {produto.Preco}");
                        Console.WriteLine($"Quantidade em Estoque do Produto: {produto.Quantidade}");
                        Console.WriteLine("\n- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\n");
                        break;
                    case "Curso":
                        Console.WriteLine($"ID do Produto: {i}\n");
                        Console.WriteLine($"Tipo do Produto: {produto.Tipo}");
                        Console.WriteLine($"Nome do Curso: {produto.Nome}");
                        Console.WriteLine($"Autor do Curso: {produto.Autor}");
                        Console.WriteLine($"Preço do Curso: {produto.Preco}");
                        Console.WriteLine("\n- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\n");
                        break;
                    case "Ebook":
                        Console.WriteLine($"ID do Produto: {i}\n");
                        Console.WriteLine($"Tipo do Produto: {produto.Tipo}");
                        Console.WriteLine($"Nome do Ebook: {produto.Nome}");
                        Console.WriteLine($"Autor do Ebook: {produto.Autor}");
                        Console.WriteLine($"Preço do Ebook: {produto.Preco}");
                        Console.WriteLine("\n- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\n");
                        break;
                }
                i++;
            }
        }

        static void Editar()
        {
            Clear();
            Alterar();
            SalvarProduto();
            CarregarProdutos();
            ProgramMenu();
        }

        static void Alterar()
        {
            Exibir();
            Console.Write("Selecione o ID do produto que deseja alterar. ");
            int id = int.Parse(Console.ReadLine());

            Clear();

            if (id >= 0 && id < produtos.Count)
            {
                switch (produtos[id].Tipo)
                {
                    case "Produto Físico":
                        Console.WriteLine($"\nNOME do Produto: {produtos[id].Nome}");
                        Console.WriteLine($"PREÇO do Produto: {produtos[id].Preco}");

                        Console.Write("\nDigite o NOME que irá substituir: ");
                        produtos[id].Nome = Console.ReadLine();

                        Console.Write("Digite o PREÇO que irá substituir: ");
                        produtos[id].Preco = float.Parse(Console.ReadLine());

                        break;
                    case "Ebook":
                        Console.WriteLine($"\nNOME do Ebook: {produtos[id].Nome}");
                        Console.WriteLine($"AUTOR do Ebook: {produtos[id].Autor}");
                        Console.WriteLine($"PREÇO do Ebook: {produtos[id].Preco}");

                        Console.Write("\nDigite o NOME que irá substituir: ");
                        produtos[id].Nome = Console.ReadLine();

                        Console.Write("Digite o AUTOR que irá substituir: ");
                        produtos[id].Autor = Console.ReadLine();

                        Console.Write("Digite o PREÇO que irá substituir: ");
                        produtos[id].Preco = float.Parse(Console.ReadLine());

                        break;
                    case "Curso":
                        Console.WriteLine($"\nNOME do Curso: {produtos[id].Nome}");
                        Console.WriteLine($"AUTOR do Curso: {produtos[id].Autor}");
                        Console.WriteLine($"PREÇO do Curso: {produtos[id].Preco}");

                        Console.Write("\nDigite o NOME que irá substituir: ");
                        produtos[id].Nome = Console.ReadLine();

                        Console.Write("Digite o AUTOR que irá substituir: ");
                        produtos[id].Autor = Console.ReadLine();

                        Console.Write("Digite o PREÇO que irá substituir: ");
                        produtos[id].Preco = float.Parse(Console.ReadLine());

                        break;
                }   
            }
            else
            {
                Clear();
                Console.Write("ID inválido! Pressione ENTER para retornar. ");
                Alterar();
            }

            Console.WriteLine("\nProduto alterado com sucesso! ");
            Console.Write("\nPressione ENTER para retornar ao menu.");
            ReadLine();

        }

        static void ListarProdutos()
        {
            Exibir();
            Console.Write("Pressione ENTER para retornar ao menu. ");
            ReadLine();
            ProgramMenu();
        }

        private static void Clear()
        {
            Console.Clear();
        }

        static void ReadLine()
        {
            Console.ReadLine();
        }

    }
}
