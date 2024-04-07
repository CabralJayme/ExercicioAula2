using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa3Aula2.Entities
{
    public class Exame
    {
        public Guid IdExame { get; set; }
        public  string Tipo { get; set; }
        public DateTime Data { get; set;}

        public string Resultado { get; set;}
        
        public Medico medico { get; set; }
        public Paciente paciente { get; set; }
    }
}
