using System.Collections.Generic;
using AulaMVC_Console.Models;
using AulaMVC_Console.Views;

namespace AulaMVC_Console.Controllers
{
    public class ProdutoController
    {
        Produto produto = new Produto();

        ProdutoView produtoView = new ProdutoView();

        public void MostrarProdutos()
        {
            List<Produto> todos = produto.Ler();
            produtoView.ListarTodos(todos);
        }

        public void Cadastrar()
        {
            //O Model está inserindo as informações capturadas na View
            produto.Inserir(produtoView.CadastrarProduto());
        }
    }
}