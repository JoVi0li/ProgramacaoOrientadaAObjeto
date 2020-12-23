using System;
using System.Collections.Generic;


namespace AulaPOO_ObjetosComArgumento.classes
{
    public class Carrinho
    {
        public float ValorTotal { get; set; }
        
        List<Produto> carrinho = new List<Produto>();

        public void AdicionarProduto(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void RemoverProduto(int cod)
        {
            Produto prodDelete = carrinho.Find(c => c.Codigo == cod);
            carrinho.Remove(prodDelete);
            Console.Beep();
        }

        public void MostrarProduto()
        {
            if(carrinho != null)
            {
                foreach (Produto p in carrinho)
                {
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Código: {p.Codigo} || R$ {p.Preco.ToString("n2")} || Nome: {p.Nome}");
                    Console.ResetColor();
                }
            }
        }
        public void MostrarTotal()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            if (carrinho != null)
            {
                foreach (Produto p in carrinho)
                {
                    ValorTotal += p.Preco;
                }
                Console.WriteLine($"Total do carrinho: R$ {ValorTotal.ToString("n2")}");
            }else{
                Console.WriteLine("Seu carrinho está vazio!");
            }
            Console.ResetColor();
        }
        public void AlterarItem(int _cod, Produto _novoProduto)
        {
            carrinho.Find(x => x.Codigo == _cod).Nome = _novoProduto.Nome;
            carrinho.Find(x => x.Codigo == _cod).Preco = _novoProduto.Preco;
        }
    }
}