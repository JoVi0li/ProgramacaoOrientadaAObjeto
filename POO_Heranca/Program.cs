using System;
using POO_Heranca.classes;

namespace POO_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica();
            PessoaJuridica pj = new PessoaJuridica();
            Pessoa p = new Pessoa();

            Console.WriteLine("Digite o seu nome:");
            p.nome = Console.ReadLine();
            Console.WriteLine("/////////////////////////");
            Console.WriteLine(p.DarBoasVindas(p.nome));

            Console.WriteLine("Você é uma pessoa física ou jurídica?");
            Console.WriteLine("[1] - Pessoa Física  [2] - Pessoa Jurídica");
            p.escolha = int.Parse(Console.ReadLine());
            
            switch (p.escolha)
            {
                case 1:
                    Console.WriteLine("Digite o seu CPF:");
                    pf.cpf = Console.ReadLine();
                    Console.WriteLine(pf.ValidarCPF(pf.cpf));
                    break;
                case 2:
                    Console.WriteLine("Digite o seu CNPJ:");
                    pj.cnpj = Console.ReadLine();
                    Console.WriteLine(pj.ValidarCNPJ(pj.cnpj));
                    break;
                default:
                    break;
            }
            
        }
    }
}
