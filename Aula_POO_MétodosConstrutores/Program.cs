using System;
using Aula_POO_MétodosConstrutores.classes;

namespace Aula_POO_MétodosConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Construtor vázio
            Produto produto1 = new Produto();
            produto1.Codigo = 172213;
            produto1.Nome = "Doritos";
            produto1.Descricao = "Salgadinho";
            produto1.Estoque = 1000;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Produto: 01 || Código: {produto1.Codigo} || Nome: {produto1.Nome} || Descrição: {produto1.Descricao} || Estoque: {produto1.Estoque}");
            Console.Beep();
            Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////");


            //Construtor apenas com  o código
            Produto produto2 = new Produto(8391248-2);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Produto: 02 || Código: {produto2.Codigo}");
            Console.Beep();
            Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////");


            //Construtor com todos os atributos
            Produto produto3 = new Produto(17312847-0, "Passatempo", "Bolacha recheada", 5000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Produto: 03 || Código: {produto3.Codigo} || Nome: {produto3.Nome} || Descrição: {produto3.Descricao} || Estoque: {produto3.Estoque}");
            Console.Beep();
            Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////");

        }
    }
}
