using System;
using AulaPOO_Interface.Classes;

namespace AulaPOO_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho carrinho =  new Carrinho();

            Produto p1 = new Produto();
            p1.Codigo = 1;
            p1.Nome = "Xbox One";
            p1.Preco = 2500;

            Produto p2 = new Produto();
            p2.Codigo = 2;
            p2.Nome = "Xbox 360";
            p2.Preco = 500;

            Produto p3 = new Produto();
            p3.Codigo = 3;
            p3.Nome = "PlayStation";
            p3.Preco = 3500;

            carrinho.Cadastrar(p1);
            carrinho.Listar();
            carrinho.Cadastrar(p2);

            Console.ForegroundColor = ConsoleColor.Blue;

            carrinho.Alterar(p1.Codigo, p3);
            Console.Beep();
            carrinho.Listar();

            Console.ResetColor();

        }
    }
}
