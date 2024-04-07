using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Tarefa3Aula2.Entities;
using Tarefa3Aula2.Interfaces;

namespace Tarefa3Aula2.Repositories
{
    public class ExameRespositoryXML: IExamesRepository
    {
        public void Exportar (Exame exame)
        {
            var xmlSerializer = new XmlSerializer(typeof(Exame));

            var streamWriter = new StreamWriter($"C:\\Users\\jayme\\OneDrive\\Desktop\\arquivosgerados\\EXAME_{exame.IdExame}.xml");

            xmlSerializer.Serialize(streamWriter, exame);

            streamWriter.Close();
        }
    }
}
