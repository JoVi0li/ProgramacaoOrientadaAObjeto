using System;
using System.Collections.Generic;
using Aula_POO_ObjetosComoArgumento.Classes;

namespace Aula_POO_ObjetosComoArgumento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto(1, "Read Dead Redemption 2", 499f);
            Produto p2 = new Produto(2, "Bully", 250f);
            Produto p3 = new Produto(3, "Overwatch", 300f);
            Produto p4 = new Produto(4, "The Last Of Us 2", 450f);

            Carrinho carrinho = new Carrinho();
            carrinho.AdicionarProduto(p1);
            carrinho.AdicionarProduto(p2);
            carrinho.AdicionarProduto(p3);
            carrinho.AdicionarProduto(p4);

            carrinho.MostrarProdutos();
        }
    }
}
