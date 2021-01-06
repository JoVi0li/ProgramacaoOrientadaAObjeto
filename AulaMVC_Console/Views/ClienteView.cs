using System;
using System.Collections.Generic;
using AulaMVC_Console.Models;

namespace AulaMVC_Console.Views
{
    public class ClienteView
    {
        public void ListarTodos(List<Cliente> clientes)
        {
            foreach(Cliente item in clientes)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Nome: {item.Nome}");
                Console.Beep();

                Console.WriteLine($"CPF: {item.CPF}");
                Console.Beep();

                Console.WriteLine($"Email: {item.Email}");
                Console.Beep();

                Console.WriteLine($"Número do cartão: {item.NumCartao}");
                Console.Beep();

                Console.WriteLine($"CEP: {item.Cep}");
                Console.Beep();

                Console.WriteLine($"Nome da Rua: {item.NomeRua}");
                Console.Beep();

                Console.WriteLine($"Número da casa: {item.NumeroCasa}");
                Console.Beep();

                Console.WriteLine("///////////////////////");
                Console.Beep();
                Console.ResetColor();

            }

        }

        public Cliente CadastrarCliente()
        {
            Cliente cliente = new Cliente();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Digite o seu nome:");
            cliente.Nome = Console.ReadLine();
            Console.Beep();
            Console.ResetColor();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Digite os cinco primeiros dígitos do seu CPF");
            cliente.CPF = int.Parse(Console.ReadLine());
            Console.Beep();
            Console.ResetColor();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Digite o seu Email");
            cliente.Email = Console.ReadLine();
            Console.Beep();
            Console.ResetColor();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Digite os quatro últimos dígitos do seu cartão de crédito:");
            cliente.NumCartao = int.Parse(Console.ReadLine());
            Console.Beep();
            Console.ResetColor();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Digite o CEP da sua rua:");
            cliente.Cep = int.Parse(Console.ReadLine());
            Console.Beep();
            Console.ResetColor();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"Digite o nome da sua rua:");
            cliente.NomeRua = Console.ReadLine();
            Console.Beep();
            Console.ResetColor();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Digite o número da sua casa:");
            cliente.NumeroCasa = int.Parse(Console.ReadLine());
            Console.Beep();
            Console.ResetColor();
            Console.WriteLine(); 

            return cliente;

        }


    }
}