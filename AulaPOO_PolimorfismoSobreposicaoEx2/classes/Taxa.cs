using System;

namespace AulaPOO_PolimorfismoSobreposicaoEx2.classes
{
    public abstract class Taxa
    {
        private float valor;

        public virtual void ValeRefeicao()
        {
            Console.WriteLine("A taxa base é: 5%");
        }
    }
}