using System;
using AulaPOO_DesafioElevador.Classes;

namespace AulaPOO_DesafioElevador.Classes
{
    public class Menu
    {
        private string nome;
        public string Nome
        {
            get{ return nome;}
            set{nome = value;}
        }

        Elevador elevador = new Elevador();

        public string MenuInicial()
        {
            int escolha;
            Console.WriteLine("Olá!");
            Console.WriteLine("Por favor, informe seu nome:");
            Nome = Console.ReadLine();
            Console.Beep();
            Console.WriteLine($"Prazer em conhecê-lo, {Nome}!!!");
            Console.WriteLine("/////////////////////////");
            Console.WriteLine("/////////////////////////");
            Console.Beep();
            Console.WriteLine($"{Nome}, selecione uma das opções abaixo:");
            Console.WriteLine("[1] - Informar a capacidade do elevador e a quantidade de andares do prédio");
            Console.WriteLine("[2] - Adicionar uma pessoa ao elevador");
            Console.WriteLine("[3] - Remover uma pessoa do elevador:");
            Console.WriteLine("[4] - Subir um andar");
            Console.WriteLine("[5] - Descer um andar");
            Console.WriteLine("[0] - Encerrar o programa");
            escolha = int.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    elevador.Inicializar(elevador.CapacidaDePessoas, elevador.QuantPessoas);
                    break;
                case 2:
                    elevador.Entrar(elevador.QuantPessoas, elevador.CapacidaDePessoas);
                    break;
                case 3:
                    elevador.Sair(elevador.QuantPessoas);
                    break;
                case 4:
                    elevador.Subir(elevador.AndarAtual, elevador.TotalDeAndares);
                    break;
                case 5:
                    elevador.Descer(elevador.AndarAtual, elevador.TotalDeAndares);
                    break;
                case 0:
                    Console.WriteLine("Tchauuuuuuuu!!!");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
            return "Menu";
        }
    }
}