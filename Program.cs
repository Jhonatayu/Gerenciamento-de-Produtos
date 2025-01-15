using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Produtos
{
    internal class Program
    {
        static List<IEstoque> produtos = new List<IEstoque>();
        enum Menu {Sair, Listar, Adicionar, Editar, Remover, Entrada, Saida }
        enum MenuCadastro {Sair, ProdutoFisico, Ebook, Curso}

        static void Main(string[] args)
        {
            ProgramMenu();
        }

        static void ProgramMenu()
        {
            Clear();
            Console.WriteLine("\t\tGerenciamento de Estoque");
            Console.WriteLine("\n1- Listar Produtos\n2- Adicionar Produto\n3- Editar Produto\n4- Remover Produto\n5- Entrada de Estoque\n6- Saída de Estoque\n0- Sair");
            Console.Write("\nSelecione uma opção: ");
            Menu opcao = (Menu)int.Parse(Console.ReadLine()); 

            switch (opcao)
            {
                case Menu.Listar:
                    break;
                case Menu.Adicionar:
                    Cadastro();
                    break;
                case Menu.Editar:
                    break;
                case Menu.Remover:
                    break;
                case Menu.Entrada:
                    break;
                case Menu.Saida:
                    break;
                case Menu.Sair:
                    Clear();
                    Console.WriteLine("Muito orbigado por utilizar nossos serviços!");
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

            Console.Write("\nDigite o ID do produto: ");
            string Id = Console.ReadLine();

            Console.Write("\nDigite o NOME do produto: ");
            string nome = Console.ReadLine();

            Console.Write("\nDigite o PREÇO do produto: ");
            float preco = float.Parse(Console.ReadLine());

            Console.Write("\nDigite a quantidade inicial do produto em estoque: ");
            int qtd = int.Parse(Console.ReadLine());


            ProdutoFisico pf = new ProdutoFisico(Id, nome, preco, qtd);
            produtos.Add(pf);

            Cadastro();
        }

        static void CadastrarEbook()
        {
            Clear();
            Console.WriteLine("\t\tCadastro de Ebook");

            Console.Write("\nDigite o ID do produto: ");
            string Id = Console.ReadLine();

            Console.Write("Digite o NOME do produto: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o nome do AUTOR: ");
            string autor = Console.ReadLine();

            Console.Write("Digite o PREÇO do produto: ");
            float preco = float.Parse(Console.ReadLine());

            Ebook ebook = new Ebook(Id, nome, autor, preco);
            produtos.Add(ebook);

            Cadastro();
        }

        static void CadastrarCurso()
        {
            Clear();
            Console.WriteLine("\t\tCadastro de Curso");

            Console.Write("\nDigite o ID do produto: ");
            string Id = Console.ReadLine();

            Console.Write("Digite o NOME do produto: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o nome do AUTOR: ");
            string autor = Console.ReadLine();

            Console.Write("Digite o PREÇO do produto: ");
            float preco = float.Parse(Console.ReadLine());

            Curso curso = new Curso(Id, nome, autor, preco);
            produtos.Add(curso);

            Cadastro();
        }

        static void Clear()
        {
            Console.Clear();
        }

        static void ReadLine()
        {
            Console.ReadLine();
        }

    }
}
