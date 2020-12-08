using System;
using AulaPOO_Encapsulamento.classes;

namespace AulaPOO_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            MasterCard masterCard = new MasterCard();


            Console.WriteLine("Os dados do seu cartão são os seguintes:");

            Console.WriteLine("Numero: "+masterCard.Numero);
            Console.WriteLine("Bandeira: "+masterCard.Bandeira);
            Console.WriteLine("Quantidade de parcelas: "+masterCard.Parcelas);
            Console.WriteLine("Limite máximo: "+masterCard.Limite);
            Console.WriteLine("CVV: "+masterCard.Cvv);

        }
    }
}
