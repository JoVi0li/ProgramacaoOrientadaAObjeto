using System;

namespace AulaPOO_PolimorfismoSobreposicaoEx2.classes
{
    public class Coordenador : Taxa
    {
        public string tipo;

        public override void ValeRefeicao()
        {
            base.ValeRefeicao();
            Console.WriteLine("A taxa do coodernador é: 15%");
        }

    }
}