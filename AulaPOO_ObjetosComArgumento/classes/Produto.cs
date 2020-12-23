using System;
using System.Collections.Generic;

namespace AulaPOO_ObjetosComArgumento.classes
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        
        public Produto()
        {

            Console.WriteLine("Digite o código do produto:");
            Codigo = int.Parse(Console.ReadLine());
            Console.Beep();
            Console.WriteLine("Digite o nome do produto:");
            Nome = Console.ReadLine();
            Console.Beep();
            Console.WriteLine("Digite o preço do produto:");
            Preco = float.Parse(Console.ReadLine());
            Console.Beep();
        }
    }
}