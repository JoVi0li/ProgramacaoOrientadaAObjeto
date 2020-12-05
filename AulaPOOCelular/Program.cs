using System;
using AulaPOOCelular.classes;

namespace AulaPOOCelular
{
    public class Program
    {
        static void Main(string[] args)
        {
            Celular celular = new Celular();
            Metodos metodos = new Metodos();

            int resposta = 0;
            Console.WriteLine("Bem-vindo ao YourPhone!");
            Console.WriteLine("Para usá-lo, ligue o celular");
            Console.WriteLine("[1] - Ligar [2] - Continuar Desligado");
            resposta = int.Parse(Console.ReadLine());
            if (resposta == 1)
            {
                metodos.Ligar();
                do
                {
                    
                    int escolha = 0;
                    Console.WriteLine("O que você deseja fazer?");
                    Console.WriteLine("[1] - Fazer uma ligação [2] - Enviar uma mensagem");
                    Console.WriteLine("[3] - Ver as especificações do seu modelo [4] - Desligar o YourPhone");
                    escolha = int.Parse(Console.ReadLine());

                    switch (escolha)
                    {
                        case 1:
                            metodos.FazerLigacao();
                            break;
                        case 2:
                            metodos.EnviarMensagem();
                            break;
                        case 3:
                            celular.Especificacoes();
                            break;
                        case 4:
                            metodos.Desligar();
                            break;
                        default:
                            Console.WriteLine("Opção inválida!");
                            break;
                    }
                } while (resposta != 4);
            }else{
                Console.WriteLine("Obrigado por usar o YourPhone!");
            }
        }
    }
}
