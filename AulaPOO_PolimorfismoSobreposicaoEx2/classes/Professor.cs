using System;

namespace AulaPOO_PolimorfismoSobreposicaoEx2.classes
{
    public class Professor : Taxa
    {
        public string turma;

        public override void ValeRefeicao()
        {
            base.ValeRefeicao();
            Console.WriteLine("A taxa do professor é: 10%");
        }
    }
}