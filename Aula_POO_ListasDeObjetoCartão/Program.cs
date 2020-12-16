using System;
using Aula_POO_ListasDeObjetoCartão.classes;
using System.Collections.Generic;

namespace Aula_POO_ListasDeObjetoCartão
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lista Criada
            List<Cartao> cartoes = new List<Cartao>();

            // Adicionamos produtos através de intâncias com construtores
            cartoes.Add( new Cartao("João", "123.456.789.123", "Visa", "04/25", "603"));
            cartoes.Add(new Cartao("Felipe", "098.765.432.109", "MasterCard", "11/22", "875"));
            cartoes.Add(new Cartao("Douglas", "019.283.746.565", "Visa", "01/21", "531"));

            foreach (Cartao c in cartoes)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Beep();
                Console.WriteLine($"Titular: {c.Titular} || Número: {c.Numero} || Bandeira: {c.Bandeira} || Vencimento: {c.Vencimento} || CVV: {c.CVV}");
            }
        }
    }
}
