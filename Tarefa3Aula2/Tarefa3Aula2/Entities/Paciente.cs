using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa3Aula2.Entities
{
    public class Paciente
    {
        public Guid IdPaciente { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set;}
        public string Sexo { get; set; }
        public string Endereco { get; set; }

    }
}
