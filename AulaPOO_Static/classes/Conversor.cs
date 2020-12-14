using System;

namespace AulaPOO_Static.classes
{
    public static class Conversor
    {
        private static float cotacaoDolar;
        private static float cotacaoEuro;
        private static float valorDolar;
        private static float valorReal;
        private static float valorEuro;

        //Convertendo real em dolar
        public static void RealParaDolar()
        {
            Console.WriteLine("Digite a cotação atual do Dolar:");
            cotacaoDolar = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de Reais:");
            valorReal = float.Parse(Console.ReadLine());
            Console.Beep();
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"US$: {valorReal / cotacaoDolar}");
        }

        //Convertendo dolar ek real
        public static void DolarParaReal()
        {
            Console.WriteLine("Digite a cotação atual do Dolar:");
            cotacaoDolar = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de Dolares:");
            valorDolar = float.Parse(Console.ReadLine());
            Console.Beep();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"R$: {valorDolar * cotacaoDolar}");
        }

        //Convertendo real em euro
        public static void RealParaEuro()
        {
            Console.WriteLine("Digite a cotação atual do Euro:");
            cotacaoEuro = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de Reais:");
            valorReal = float.Parse(Console.ReadLine());
            Console.Beep();

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Console.Out.WriteLine("œil");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\u20AC: {valorReal / cotacaoEuro}");
        }

        //Convertendo euro em real
        public static void EuroParaReal()
        {
            Console.WriteLine("Digite a cotação atual do Euro:");
            cotacaoEuro = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de Euros:");
            valorEuro = float.Parse(Console.ReadLine());
            Console.Beep();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"R$: {valorEuro * cotacaoEuro}");
        }

    }
}