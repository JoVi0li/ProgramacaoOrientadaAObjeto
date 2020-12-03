using System;


namespace AulaPOOCelular.classes
{
    public class Metodos
    {

        //Método para LIGAR
        public string Ligar()
        {
            Console.WriteLine("Celular iniciando........");
            Console.WriteLine("..........................");
            Console.WriteLine("..........................");
            Console.WriteLine("...Celular Iniciado!"); 
            return this.Ligar();         
        }

        //Método para DESLIGAR
        public string Desligar()
        {
            Console.WriteLine("Celular desligando");
            Console.WriteLine("..........................");
            Console.WriteLine("..........................");
            Console.WriteLine("...Celular desligado!");
            return this.Desligar();           
        }

        //Método para FAZER UMA LIGAÇÃO
        public int FazerLigacao()
        {
            Console.WriteLine("Selecione uma das opções abaixo:");
            Console.WriteLine("[1] - Ligar para um contato salvo [2] - Discar um numero");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Ligando();
                    break;
                case 2:
                Discando();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
            return this.FazerLigacao();
        }

                //Método para SELECIONAR UM NÚMERO PARA LIGAR
                public int Ligando()
                {     
                    int escolha = 0;
                    Console.WriteLine("Selecione um dos contatos:");
                    Console.WriteLine("[1] - Batman");
                    Console.WriteLine("[2] - Ademir");
                    Console.WriteLine("[3] - Cleytinho");
                    Console.WriteLine("[4] - Carlos Aubé");
                    Console.WriteLine("[5] - Jurandi");
                    escolha = int.Parse(Console.ReadLine());

                    switch (escolha)
                    {
                        case 1:
                            Console.WriteLine("Ligando para o Batman....");
                            Console.WriteLine("..........................");
                            Console.WriteLine("..........................");
                            break;
                        case 2:
                            Console.WriteLine("Ligando para o Ademir....");
                            Console.WriteLine("..........................");
                            Console.WriteLine("..........................");
                            break;
                        case 3:
                            Console.WriteLine("Ligando para o Cleytinho....");
                            Console.WriteLine("..........................");
                            Console.WriteLine("..........................");
                            break;
                        case 4:
                            Console.WriteLine("Ligando para o Carlos Aubé....");
                            Console.WriteLine("..........................");
                            Console.WriteLine("..........................");
                            break;
                        case 5:
                            Console.WriteLine("Ligando para o jurandi....");
                            Console.WriteLine("..........................");
                            Console.WriteLine("..........................");
                            break;
                        default:
                            Console.WriteLine("Opção inválida!");
                            break;
                    }
                    return this.Ligando();
                }

                //Método para DIGITAR UM NÚMERO PARA LIGAR
                public int Discando()
                {
                    int numero;
                    Console.WriteLine("Digite o número:");
                    numero = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Ligando para {numero}........");                            Console.WriteLine("..........................");
                    Console.WriteLine("..........................");
                    return this.Discando();
                }

                //Método para SELECIONAR UM NÚMERO PARA ENVIAR MENSAGEM
                public int Enviando()
                {
                    int escolha = 0;
                    Console.WriteLine("Selecione um dos contatos:");
                    Console.WriteLine("[1] - Batman");
                    Console.WriteLine("[2] - Ademir");
                    Console.WriteLine("[3] - Cleytinho");
                    Console.WriteLine("[4] - Carlos Aubé");
                    Console.WriteLine("[5] - Jurandi");
                    escolha = int.Parse(Console.ReadLine());

                    switch (escolha)
                    {
                        case 1:
                            Console.WriteLine("Enviando mensagem para o Batman....");
                            Console.WriteLine("..........................");
                            Console.WriteLine("..........................");
                            break;
                        case 2:
                            Console.WriteLine("Enviando mensagem para o Ademir....");
                            Console.WriteLine("..........................");
                            Console.WriteLine("..........................");
                            break;
                        case 3:
                            Console.WriteLine("Enviando mensagem para o Cleytinho....");
                            Console.WriteLine("..........................");
                            Console.WriteLine("..........................");
                            break;
                        case 4:
                            Console.WriteLine("Enviando mensagem para o Carlos Aubé....");
                            Console.WriteLine("..........................");
                            Console.WriteLine("..........................");
                            break;
                        case 5:
                            Console.WriteLine("Enviando mensagem para o Jurandi....");
                            Console.WriteLine("..........................");
                            Console.WriteLine("..........................");
                            break;
                        default:
                            Console.WriteLine("Opção inválida!");
                            break;
                    }
                    return this.Enviando();
                }

                //Método para DIGITAR UM NÚMERO PARA ENVIAR UMA MENSAGEM
                public int EnviandoNovoContato()
                {
                    int numero;
                    Console.WriteLine("Digite o número:");
                    numero = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Envinado mensagem para {numero}........"); 
                    Console.WriteLine("..........................");
                    return this.EnviandoNovoContato();
                }
                //Método para ENVIAR UMA MENSAGEM
                public int EnviarMensagem()
                {
                    int escolha = 0;
                    Console.WriteLine("Selecione uma das opções abaixo:");
                    Console.WriteLine("[1] - Enviar mensagem para um contato salvo [2] - Enviar mensagem para um novo contato");
                    escolha = int.Parse(Console.ReadLine());

                    if (escolha == 1)
                    {
                        Enviando();
                    }else
                    {
                        EnviandoNovoContato();
                    }
                    return this.EnviarMensagem();
                }

    }
}