using System;
using System.Collections.Generic;

namespace AulaPOO_ProjetoDeProdutos.Classes
{
    public class Produto
    {
        public int Codigo { get; set; }
        
        public string NomeProduto { get; set; }
        
        public float Preco { get; set; }
        
        public DateTime DataCadastro { get; set; }
        
        public Marca Marca = new Marca();

        public Usuario CadastradoPor = new Usuario();
        
        public List<Produto> ListaDeProdutos = new List<Produto>();
        

        public void Cadastrar()
        {
            Produto novoProduto = new Produto();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Digite o código do produto:");
            novoProduto.Codigo = int.Parse(Console.ReadLine());
            Console.Beep();


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Digite o nome do produto:");
            novoProduto.NomeProduto = Console.ReadLine();
            Console.Beep();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Digite o preço do produto:");
            novoProduto.Preco = float.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.Beep();

            novoProduto.DataCadastro = DateTime.UtcNow;

            novoProduto.Marca = Marca.CadastrarMarca();

            // novoProduto.CadastradoPor = new Usuario();
            
            ListaDeProdutos.Add(novoProduto);
            
        }

        public void Listar()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (Produto item in ListaDeProdutos)
            {

                Console.WriteLine($"Produto: {item.NomeProduto} || Código: {item.Codigo} || Preço: R${item.Preco} || Data de cadastro: {item.DataCadastro} || Marca: {item.Marca.NomeDaMarca} || Cadastrado por: {item.CadastradoPor.Nome}");

            }
            Console.ResetColor();

        }   

        public void Deletar(int cod)
        {
            Produto prodDelete = ListaDeProdutos.Find(p => p.Codigo == cod);
            ListaDeProdutos.Remove(prodDelete);
            Console.Beep();
        }
    }
}