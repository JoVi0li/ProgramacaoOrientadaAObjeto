using System.Collections.Generic;
using AulaMVC_Console.Models;
using System;

namespace AulaMVC_Console.Views
{
    public class ProdutoView
    {
        public void ListarTodos(List<Produto> produtos)
        {
            foreach(Produto item in produtos)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preço: R${item.Preco}");
                Console.WriteLine("///////////////////////");
                Console.WriteLine();
                Console.Beep();
                Console.ResetColor();
            }

        }

        public Produto CadastrarProduto()
        {
            Produto produto = new Produto();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Digite o código:");
            produto.Codigo = int.Parse(Console.ReadLine());
            Console.Beep();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Digite o nome:");
            produto.Nome = Console.ReadLine();
            Console.Beep();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Digite o preço do produto");
            produto.Preco = float.Parse(Console.ReadLine());
            Console.Beep();
            Console.ResetColor();
            
            return produto;
            
        }
         
         
    }
}