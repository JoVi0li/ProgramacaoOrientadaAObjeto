using System;
using AulaMVC_Console.Controllers;
using AulaMVC_Console.Models;

namespace AulaMVC_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController produtoController = new ProdutoController();
            produtoController.MostrarProdutos();
        }
    }
}
