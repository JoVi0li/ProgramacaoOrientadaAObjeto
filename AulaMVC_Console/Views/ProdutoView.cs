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
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preço: R${item.Preco}");
                Console.WriteLine("///////////////////////");
                Console.WriteLine();
                Console.Beep();
            }

        }
         
         
    }
}