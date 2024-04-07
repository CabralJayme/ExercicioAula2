using ExercicioAula2.Entities;
using ExercicioAula2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula2.Controllers

    
{
    /// <summary>
    /// Controler Implementa o cadastro dos produtos e implementa a exportação dos dados para TXT
    /// </summary>
    public class ProdutosController
    {
        public void CadastrarProdutos()
        {
            Console.WriteLine("\n CADASTRO DE PRODUTOS: \n");

            var produto = new Produto()
            {
                Id = Guid.NewGuid(),
                Categoria = new Categoria()
                {
                    Id = Guid.NewGuid()
                }
            };


            Console.Write("NOME DO PRODUTO:...");
            produto.Nome = Console.ReadLine();

            Console.Write("DESCRIÇÃO:...................");
            produto.descricao = Console.ReadLine();

            Console.Write("PREÇO:.............");
            produto.preco = double.Parse(Console.ReadLine());

            Console.Write("QUANTIDADE:...............");
            produto.quantidade = int.Parse(Console.ReadLine());


            Console.Write("CODIGO:...............");
            produto.Categoria.codigo = Console.ReadLine();

            Console.Write("DESCRIÇÃO:...............");
            produto.Categoria.descricao = Console.ReadLine();


            #region Exportar para TXT

            var produtosRepository = new ProdutoRepository();

            produtosRepository.DataExport(produto);

            Console.WriteLine("DADOS GRAVADOS COM SUCESSO");

            #endregion

        }

    }
}
