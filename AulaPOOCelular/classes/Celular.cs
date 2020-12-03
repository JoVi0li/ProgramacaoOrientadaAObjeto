using System;

namespace AulaPOOCelular.classes
{
    public class Celular
    {
        string cor;
        string modelo;
        string tamanho;
        public bool ligado;

        public string Especificacoes()
        {
            cor = "Vermelho";
            modelo = "YP1";
            tamanho = "Tela de 6,7 polegadas";
            Console.WriteLine($"Modelo: {modelo}");
            Console.WriteLine($"Tamanho: {tamanho}");
            Console.WriteLine($"Cor {cor}");
            return this.Especificacoes();
        }
    }
}