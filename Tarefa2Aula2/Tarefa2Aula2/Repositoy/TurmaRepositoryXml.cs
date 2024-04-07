using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Tarefa2Aula2.Entities;

namespace Tarefa2Aula2.Repositoy
{
    public class TurmaRepositoryXml
    {
        public void Exportar(Turma turma)
        {
           

            var xmlSerializer = new XmlSerializer(typeof(Turma));

            

            var streamWriter = new StreamWriter($"C:\\Users\\jayme\\OneDrive\\Desktop\\arquivosgerados\\turma_{turma.IdTurma}.xml");

            

            xmlSerializer.Serialize(streamWriter, turma);

            

            streamWriter.Close();

            
        }
    }
}
