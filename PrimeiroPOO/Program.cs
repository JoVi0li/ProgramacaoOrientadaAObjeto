using System;

namespace PrimeiroPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem objetoPersonagem1 = new Personagem();
            Personagem objetoPersonagem2 = new Personagem();

            objetoPersonagem1.nome = "João Vitor";
            objetoPersonagem1.idade = 16;
            objetoPersonagem1.armadura = "Mark3";

            objetoPersonagem2.nome = "Felipe";
            objetoPersonagem2.idade = 26;
            objetoPersonagem2.armadura = "Troll";

            Console.WriteLine($"Personagem: {objetoPersonagem1.nome} - Armadura: {objetoPersonagem1.armadura} - {objetoPersonagem1.Atacar()}");
            Console.WriteLine($"Personagem: {objetoPersonagem2.nome} - Armadura: {objetoPersonagem2.armadura} - {objetoPersonagem2.Defender()}");

        }
    }
}
