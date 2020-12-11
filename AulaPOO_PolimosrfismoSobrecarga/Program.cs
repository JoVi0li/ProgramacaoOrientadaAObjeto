using System;
using AulaPOO_PolimosrfismoSobrecarga.classes;

namespace AulaPOO_PolimosrfismoSobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Mostrar();
            Console.Beep();
            funcionario.Mostrar("João");
            Console.Beep();
            funcionario.Mostrar(8);
            Console.Beep();
        }
    }
}
