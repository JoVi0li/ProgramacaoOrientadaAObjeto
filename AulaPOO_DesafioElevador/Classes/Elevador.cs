using System;

namespace AulaPOO_DesafioElevador.Classes
{
    public class Elevador
    {
        private int andarAtual;
        public int AndarAtual
        {
            get{ return andarAtual;}
            set{andarAtual = value;}
        }

        private int capacidaDePessoas;
        public int CapacidaDePessoas
        {
            get{ return capacidaDePessoas;}
            set{capacidaDePessoas = value;}
        }

        private int quantPessoas;
        public int QuantPessoas
        {
            get{ return quantPessoas;}
            set{quantPessoas = value;}
        }

        private int totalDeAndares;
        public int TotalDeAndares
        {
            get{ return totalDeAndares;}
            set{totalDeAndares = value;}
        }


        public string Inicializar(int capacidadePessoas, int totalDeAndares)
        {
            Console.WriteLine("Digite quantas pessoas o elevador suporta:");
            capacidadePessoas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite quantos andares tem o prédio:");
            totalDeAndares = int.Parse(Console.ReadLine());
            return "Inicializado";
        }


        public int Entrar(int quantPessoas, int capacidadePessoas)
        {
            for (var i = 0; i < capacidadePessoas; i++)
            {
                int escolha;
                Console.WriteLine("Deseja adicionar mais uma pessoa?");
                Console.WriteLine("[1] - Sim  [2] - Não");
                escolha = int.Parse(Console.ReadLine());

                if (escolha == 1)
                {
                    quantPessoas =+quantPessoas;
                }else{
                    
                }
            }
            return quantPessoas;
        }


        public int Sair(int quantPessoas)
        {
            for (var i = 0; i < quantPessoas; i++)
            {
                int escolha;
                Console.WriteLine("Deseja remover mais uma pessoa?");
                Console.WriteLine("[1] - Sim  [2] - Não");
                escolha = int.Parse(Console.ReadLine());

                if (escolha == 1)
                {
                    quantPessoas =-quantPessoas;
                }else{
                    
                }
            }
            return quantPessoas;
        }

        public int Subir(int andarAtual, int totalDeAndares)
        {
            for (var i = 0; i < totalDeAndares; i++)
            {
                int escolha;
                Console.WriteLine("Deseja subir mais um andar?");
                Console.WriteLine("[1] - Sim  [2] - Não");
                escolha = int.Parse(Console.ReadLine());

                if (escolha == 1)
                {
                    andarAtual =+andarAtual;
                }else{
                    
                }
            }
            return andarAtual;
        }

        public int Descer(int andarAtual, int totalDeAndares)
        {
            for (var i = 0; i < totalDeAndares; i++)
            {
                int escolha;
                Console.WriteLine("Deseja descer mais um andar?");
                Console.WriteLine("[1] - Sim  [2] - Não");
                escolha = int.Parse(Console.ReadLine());

                if (escolha == 1)
                {
                    andarAtual =-andarAtual;
                }else{
                    
                }
            }
            return andarAtual;

        }

    }
}