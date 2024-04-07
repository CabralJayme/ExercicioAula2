using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa2Aula2.Entities
{
    public class Curso
    {
        public Guid IdCurso { get; set; }
        public string titulo { get; set; }

        public int CargaHoraria { get; set; }
    }
}
