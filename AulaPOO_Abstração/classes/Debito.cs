using System;

namespace AulaPOO_Abstração.classes
{
    public class Debito : Cartao
    {
        private float saldo = 600;

        public void Pagar(float valorDaCompra)
        {
            if (valorDaCompra <= 600)
            {
                Console.WriteLine($"Pagamento efetuado no valor de: R${valorDaCompra}");
                Console.WriteLine($"O saldo restante é de: R${saldo-valorDaCompra}");
            }
        }

    }
}