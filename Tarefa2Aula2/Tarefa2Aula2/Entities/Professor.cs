using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa2Aula2.Entities
{
    public class Professor
    {
        public Guid IdProfessor { get; set; }

        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }


        #region relacionamento
        public Curso curso { get; set; }
        #endregion

    }
}
