using System;

namespace AulaPOO_Abstração.classes
{
    public abstract class Cartao : Pagamento
    {
        private string bandeira;
        public string Bandeira
        {
            get{return bandeira;}
            set{bandeira = value;}
        }
        private string numero;
        public string Numero
        {
            get{return numero;}
            set{numero = value;}
        }

        private string titular;
        public string Titular
        {
            get{return titular;}
            set{titular = value;}
        }

        private string cvv;
        public string Cvv
        {
            get{return cvv;}
            set{cvv = value;}
        }


        public string SalvarCartao()
        {
            Console.WriteLine("Digite a bandeira do cartão:");
            Titular = Console.ReadLine();
            Console.WriteLine("Digite o número do cartão:");
            Numero = Console.ReadLine();
            Console.WriteLine("Digite o nome do titular do cartão:");
            Titular = Console.ReadLine();
            Console.WriteLine("Digite o CVV do cartão:");
            Cvv = Console.ReadLine();
            return "Cartão salvo";
        }
    }
}