using System;
using AulaPOO_PolimorfismoSobreposicaoEx2.classes;

namespace AulaPOO_PolimorfismoSobreposicaoEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor professor = new Professor();
            professor.ValeRefeicao();

            Coordenador coordenador = new Coordenador();
            coordenador.ValeRefeicao();

        }
    }
}
