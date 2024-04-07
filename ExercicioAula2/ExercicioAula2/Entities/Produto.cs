using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula2.Entities
{
    public class Produto

    {
        #region Atributos
        public Guid Id { get; set; }
        public string Nome { get; set; }

        public string descricao { get; set; }

        public double preco { get; set; }

        public int quantidade { get; set; }


        #endregion

        #region Categorias

        public Categoria Categoria { get; set; }

        #endregion

    }
}
