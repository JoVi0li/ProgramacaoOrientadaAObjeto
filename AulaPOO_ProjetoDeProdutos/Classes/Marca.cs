using System;
using System.Collections.Generic;

namespace AulaPOO_ProjetoDeProdutos.Classes
{
    public class Marca
    {
        public int Codigo { get; set; }

        public string NomeDaMarca { get; set; }

        public DateTime DataDeCadastro { get; set; }

        public List<Marca> Marcas =  new List<Marca>(); 

        public Marca CadastrarMarca()
        {
            Marca novaMarca = new Marca();
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Digite o código da marca:");
            novaMarca.Codigo = int.Parse(Console.ReadLine());
            Console.Beep();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Digite o nome da marca:");
            novaMarca.NomeDaMarca = Console.ReadLine();
            Console.Beep();
            Console.ResetColor();

            DataDeCadastro = DateTime.UtcNow;

            Marcas.Add(novaMarca);

            return novaMarca;
        }

        public void Listar()
        {
            foreach (Marca item in Marcas)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Beep();
                Console.WriteLine($"Marca: {item.NomeDaMarca} || Código: {item.Codigo}  || Data do cadastro: {item.DataDeCadastro}");
                Console.ResetColor();
            }
        }

        public void Deletar(int cod)
        {
            Marca marcaDelete = Marcas.Find(x => x.Codigo == cod);
            Marcas.Remove(marcaDelete);
            Console.Beep();
        }
    }
}