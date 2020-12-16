using System;
using AulaPOO_ListasDeObjeto.classes;
using System.Collections.Generic;

namespace AulaPOO_ListasDeObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista criada
            List<Produto> produtos = new List<Produto>();


            // Adicionado produtos através de intâncias com construtores
            produtos.Add(new Produto(1, "Apple Watch", 4.999f));
            produtos.Add( new Produto(2, "Xiaomi Watch", 1.099f));
            produtos.Add(new Produto(3, "Zenfone Asus", 3.600f));
            produtos.Add(new Produto(4, "Samsung", 1.500f));
            produtos.Add(new Produto(5, "Motorola G8", 999.99f));

            // Ou através de intâncias básicas e suas atribuições
            Produto iphone = new Produto();
            iphone.Codigo = 6;
            iphone.Nome = "Iphone 12";
            iphone.Preco = 13.999f;

            produtos.Add(iphone);

            
            // Podemos mostrar os produtos com foreach
            foreach(Produto p in produtos)
            {
                Console.WriteLine($"Nome: {p.Nome} || Preço: {p.Preco}");
            }

            // Podemos remover itens através  de seu índice de array
            // Linha removida na posição 3 do array: Produto (4, "Samsung", 1.500f);
            produtos.RemoveAt(3);

            // Podemos remover um produto da lista usando a expressão lambda e o método removeAll:
            // Linha removida: Produto (1, "Apple Watch", 4.999f);
            produtos.RemoveAll(x => x.Nome == "Apple Watch");


            // Checamos se foi realmente removido
            Console.WriteLine("\nLista Alterada: ");
            foreach (Produto p in produtos)
            {
                Console.WriteLine($"Nome: {p.Nome} || Preço: {p.Preco}");
            }

            
        }
    }
}
