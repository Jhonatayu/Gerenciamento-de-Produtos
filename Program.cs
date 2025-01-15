using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Produtos
{
    internal class Program
    {
        enum Menu {Sair, Listar, Adicionar, Editar, Remover, Entrada, Saida }

        static void Main(string[] args)
        {

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

        static void Adicionar()
        {

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
