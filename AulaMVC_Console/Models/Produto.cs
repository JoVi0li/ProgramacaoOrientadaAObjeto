using System.Collections.Generic;
using System.IO;

namespace AulaMVC_Console.Models
{
    public class Produto
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public float Preco { get; set; }

        private const string PATH = "Database/Produto.csv";

        public Produto()
        {
            string pasta = PATH.Split("/")[0];

            //Criando e verificando a existência da pasta
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }


            // Verificando a existência do arquivo Produto.csv, caso não exista, será criada uma
            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }
            
        }  

        public List<Produto> Ler()
        {
            List<Produto> produtos = new List<Produto>();

            //Obtendo as informações do arquivo CSV
            string[] linhas = File.ReadAllLines(PATH);

            foreach (string item in linhas)
            {
                //Separando atributos pelo ";"
                string[] atributos = item.Split(";");
                
                //Criando um produto vázio para poder colocar na lista final de produtos
                Produto prod = new Produto();
                prod.Codigo  = int.Parse(atributos[0]);
                prod.Nome    = atributos[1];
                prod.Preco   = float.Parse(atributos[2]);

                produtos.Add(prod);
            }


            return produtos;
        }

        public void Inserir(Produto p)
        {
            //Criação de um array de String parao método AppendAllLines
            string[] linhas = {PrepararLinhaCSV(p)};

            //Inserindo o array de linhas no arquivo CSV
            File.AppendAllLines(PATH, linhas);
        }

        public string PrepararLinhaCSV(Produto prod)
        {
            //Formatando a linha para o formato CSV
            return $"{prod.Codigo};{prod.Nome};{prod.Preco}";
        }
    }
}