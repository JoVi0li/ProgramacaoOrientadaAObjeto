using System;
using AulaPOO_PolimorfismoSobreposicao.classes;

namespace AulaPOO_PolimorfismoSobreposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            MegaMan megaMan = new MegaMan();
            Console.WriteLine($"MegaMan - {megaMan.Correr()}");

            Zero zero = new Zero();
            Console.WriteLine($"Zero - {zero.Correr()}");
        }
    }
}
