using System;
using AulaPOO_ObjetosComArgumento.classes;
using System.Collections.Generic;

namespace AulaPOO_ObjetosComArgumento
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha;

            Carrinho carrinho = new Carrinho();

            Console.WriteLine("Olá!");
            do
            {
                Console.WriteLine("Selecione uma das opções abaixo:");
                Console.WriteLine("[1] - Adicionar produto || [2] - Remover produto || [3] - Mostrar produtos || [4] - Mostrar valor final || [5] - Alterar carrinho || [0] - Sair");
                escolha = int.Parse(Console.ReadLine());

                switch(escolha)
                {
                    case 1:
                        
                        carrinho.AdicionarProduto(new Produto());
                        break;
                    case 2:
                        Console.WriteLine("Digite o código do produto que deseja remover:");
                        int cod =  int.Parse(Console.ReadLine());
                        carrinho.RemoverProduto(cod);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Produto removido!");
                        Console.ResetColor();
                        break;
                    case 3:
                        carrinho.MostrarProduto();
                        break;
                    case 4:
                        carrinho.MostrarTotal();
                        break;
                    case 5:
                        Console.WriteLine("Digite o código do produto que deseja alterar:");
                        int _cod  = int.Parse(Console.ReadLine());
                        carrinho.AlterarItem(_cod, new Produto());
                        break;
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Beep();
                        Console.WriteLine("Programa encerrado!");
                        Console.ResetColor();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Beep();
                        Console.WriteLine("Opção inválida!");
                        Console.ResetColor();
                        break;
                }
            }while (escolha != 0);
  
        }
    }
}
