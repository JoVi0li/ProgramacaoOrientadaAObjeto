using System;
using AulaPOO_Abstração.classes;

namespace AulaPOO_Abstração
{
    class Program
    {
        static void Main(string[] args)
        {                
            Console.WriteLine("Digite o valor da compra:");
            float valorDaCompra = float.Parse(Console.ReadLine());

            Console.WriteLine("Selecione o tipo de pagamento:");
            Console.WriteLine("[1] - Boleto  [2] - Cartão");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Boleto boleto =  new Boleto();
                    boleto.Valor = valorDaCompra;
                    boleto.Registrar(boleto.Valor, boleto.Data, boleto.CodigoDeBarras);
                    break;
                case 2:
                    Console.WriteLine("Selecione o tipo de pagamento:");
                    Console.WriteLine("[1] - Crédito  [2] - Débito");
                    int tipoCartao = int.Parse(Console.ReadLine());
                        switch (tipoCartao)
                        {
                            case 1:
                            Credito credito = new Credito();
                            credito.SalvarCartao();
                            credito.Pagar(valorDaCompra);
                                break;
                            case 2:
                            Debito debito = new Debito();
                            debito.SalvarCartao();
                            debito.Pagar(valorDaCompra);
                                break;
                            default:
                                Console.WriteLine("Opção inválida!");
                                break;
                        }
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
            
        }
    }
}
