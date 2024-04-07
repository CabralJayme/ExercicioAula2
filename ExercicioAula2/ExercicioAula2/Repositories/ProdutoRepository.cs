using ExercicioAula2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula2.Repositories
{
    public class ProdutoRepository
    {
        public void DataExport(Produto produto)
        {
            var streamWriter = new StreamWriter("C:\\Users\\jayme\\OneDrive\\Desktop\\arquivosgerados\\Produtos.txt", true);

            streamWriter.WriteLine("ID..........:" + produto.Id);
            streamWriter.WriteLine("Nome........:" + produto.Nome);
            streamWriter.WriteLine("Descrição...:" + produto.descricao);
            streamWriter.WriteLine("Preco.......:" + produto.preco.ToString("c"));
            streamWriter.WriteLine("Quantidade..:" + produto.quantidade);
            streamWriter.WriteLine("Codigo......:" + produto.Categoria.codigo);
            streamWriter.WriteLine("Descricao...:" + produto.Categoria.descricao);

            streamWriter.WriteLine("...");

            streamWriter.Close();
        }

    }
}
