using System.Collections.Generic;
using System.IO;

namespace AulaMVC_Console.Models
{
    public class Cliente
    {
        public string Nome { get; set; }
        
        public int CPF { get; set; }
        
        public string Email { get; set; }

        public int NumCartao { get; set; }
        
        
        public int Idade { get; set; }
        
        public int Cep { get; set; }
        
        public string NomeRua { get; set; }
        
        public int NumeroCasa { get; set; }

        private const string PATH = "Database/Cliente.csv";

        
        public Cliente()
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

        public List<Cliente> Ler()
        {
            List<Cliente> clientes = new List<Cliente>();

            //Obtendo as informações do arquivo CSV
            string[] linhas = File.ReadAllLines(PATH);

            foreach (string item in linhas)
            {
                //Separando atributos pelo ";"
                string[] atributos = item.Split(";");
                
                //Criando um produto vázio para poder colocar na lista final de produtos
                Cliente cliente    = new Cliente();
                cliente.Nome       = atributos[0];
                cliente.CPF        = int.Parse(atributos[1]);
                cliente.Email      = atributos[2];
                cliente.NumCartao  = int.Parse(atributos[3]);
                cliente.Cep        = int.Parse(atributos[4]);
                cliente.NomeRua    = atributos[5];
                cliente.NumeroCasa = int.Parse(atributos[6]);

                clientes.Add(cliente);
            }

            return clientes;
        }

        public void Inserir(Cliente c)
        {
            //Criação de um array de String parao método AppendAllLines
            string[] linhas = {PrepararLinhaCSV(c)};

            //Inserindo o array de linhas no arquivo CSV
            File.AppendAllLines(PATH, linhas);
        }

        public string PrepararLinhaCSV(Cliente c)
        {
            //Formatando a linha para o formato CSV
            return $"{c.Nome};{c.CPF};{c.Email};{c.Idade};{c.Cep};{c.NomeRua};{c.NumeroCasa}";
        }

    }
}