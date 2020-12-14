using System;

namespace AulaPOO_PolimosrfismoSobrecarga.classes
{
    public class Funcionario
    {
            public string[] lista = {"João", "Douglas", "Caio", "Guilherme", "Gabriel"};
            public void Mostrar()
            {
                foreach(var item in lista)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(item);
                    Console.ResetColor();
                }
            }
            public void Mostrar(int indice)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (indice < lista.Length)
                {
                    Console.WriteLine(lista[indice]);
                }else
                {
                    Console.WriteLine("Índice não encontrado!");
                }
                Console.ResetColor();
            }
            public void Mostrar(string busca)
            {
                foreach(var item in lista)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    if(item == busca)
                    {
                        Console.WriteLine($"Resultado da busca: {item}");
                    }
                    Console.ResetColor();
                }
            }
    }
}