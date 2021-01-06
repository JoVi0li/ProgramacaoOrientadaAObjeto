using System;
using AulaMVC_Console.Controllers;
using AulaMVC_Console.Models;

namespace AulaMVC_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha;
            ProdutoController produtoController = new ProdutoController();
            ClienteController clienteController = new ClienteController();
            do
            {
                Console.WriteLine($"Olá!");
                Console.WriteLine($"Selecione uma opção:");
                Console.WriteLine($"[1] - Cadastrar cliente");
                Console.WriteLine();
                Console.WriteLine($"[2] - Listar os clientes cadastrados");
                Console.WriteLine();
                Console.WriteLine($"[3] - Cadastrar produto");
                Console.WriteLine();
                Console.WriteLine($"[4] - Listar os produtos cadastrados");
                Console.WriteLine();
                Console.WriteLine($"[5] - Encerrar o programa");
                Console.WriteLine();
                Console.WriteLine($"////////////////////////////////////////////");
                

                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                    clienteController.CadastrarCliente();
                        break;
                    case 2:
                    clienteController.MostrarCliente();
                        break;
                    case 3:
                    produtoController.Cadastrar();
                        break;
                    case 4:
                    produtoController.MostrarProdutos();
                        break;
                    case 5:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Programa encerrado!");
                    Console.Beep();
                    Console.ResetColor();
                        break;
                    default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Opção inválida!");
                    Console.Beep();
                    Console.ResetColor();
                        break;
                }

            } while (escolha != 5);
            



            
            
            
            
            
            
            

        }
    }
}
