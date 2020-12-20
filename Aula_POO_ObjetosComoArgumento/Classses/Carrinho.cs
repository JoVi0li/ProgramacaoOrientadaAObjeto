using System;
using System.Collections.Generic;

namespace Aula_POO_ObjetosComoArgumento.Classes
{
    public class Carrinho
    {
        public float ValorTotal { get; set; }
        
        List<Produto> listaDeProdutos = new List<Produto>();

        public void AdicionarProduto(Produto produto)
        {
            
            listaDeProdutos.Add(produto);
        }

        public void RemoverProduto(Produto produto)
        {
            listaDeProdutos.Remove(produto);
        }

        public void MostrarProdutos()
        {
            if (listaDeProdutos != null)
            {
                foreach (Produto p in listaDeProdutos)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Beep();
                    Console.WriteLine($"Produto: {p.Nome} || Preço: R${p.Preco}");
                    Console.ResetColor();
                }
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Beep();
                Console.WriteLine("O carrinho está vazio!");
                Console.ResetColor();
            }
        }

        public void AlterarItem(int _codigo, Produto _produtoNovo)
        {
            if (_produtoNovo.Nome != null)
            {
                listaDeProdutos.Find(x => x.Codigo == _codigo).Nome = _produtoNovo.Nome;                
            }
                listaDeProdutos.Find(x => x.Codigo == _codigo).Preco = _produtoNovo.Preco;                
        }

        public void MostrarTotal()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            if (listaDeProdutos != null)
            {
                foreach (Produto p  in listaDeProdutos)
                {
                    ValorTotal += p.Preco;                    
                }
                Console.WriteLine($"Total do carrinho: R$ {ValorTotal.ToString("n2")}");
            }
            else
            {
                Console.WriteLine("O carrinho está vazio!");
            }
            Console.ResetColor();
        }
    }
}