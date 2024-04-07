using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa2Aula2.Entities
{
    public class Turma
    {
        public Guid IdTurma { get; set; }
        public string Nome  { get; set; }

        public string DataInicio { get; set; }


        public Professor Professor { get; set; }
    }
}
