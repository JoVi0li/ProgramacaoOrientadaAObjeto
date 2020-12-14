using System;
using AulaPOO_Static.classes;

namespace AulaPOO_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha;


            Console.WriteLine("Hello World!");
            Console.WriteLine("Qual conversão gostaria de fazer?");
            Console.WriteLine("[1] - Real para Dolar [2] - Dolar para Real");
            Console.WriteLine("[3] - Real para Euro [3] - Euro para Real");
            escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Conversor.RealParaDolar();
                    break;
                case 2:
                    Conversor.DolarParaReal();
                    break;
                case 3:
                    Conversor.RealParaEuro();
                    break;
                case 4:
                    Conversor.EuroParaReal();
                    break;
                case 0:
                    Console.WriteLine("///////////////////////////");
                    Console.WriteLine("///////////////////////////");
                    Console.Beep();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
            
        }
    }
}
