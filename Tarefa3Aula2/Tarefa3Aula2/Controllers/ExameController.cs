using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarefa3Aula2.Entities;
using Tarefa3Aula2.Repositories;

namespace Tarefa3Aula2.Controllers
{
    public class ExameController
    {
        public void CadastrarExame()
        {
            Console.WriteLine("CADASTRO DE EXAMES");

            var exame = new Exame()
            {
                IdExame = Guid.NewGuid(),
                paciente = new Paciente()
                {
                    IdPaciente = Guid.NewGuid(),
                },
                medico = new Medico()
                {
                    IdMedico = Guid.NewGuid(),
                },
                Data = DateTime.Now
            };

            Console.Write("INFORME NOME DO PACIENTE..: ");
            exame.paciente.Nome = Console.ReadLine();

            Console.Write("INFORME A IDADE DO PACIENTE:.. ");
            exame.paciente.Idade = int.Parse(Console.ReadLine());

            Console.Write("INFORME O SEXO DO PACIENTE (M,F): ");
            exame.paciente.Sexo = Console.ReadLine();

            Console.Write("INFORME O ENDEREÇO DO PACIENTE:.. ");
            exame.paciente.Endereco = Console.ReadLine();

            Console.Write("INFORME O NOME DO MÉDICO:.. ");
            exame.medico.Nome = Console.ReadLine();

            Console.Write("INFORME A ESPECIALIDADE DO MÉDICO:.. ");
            exame.medico.Especialidade = Console.ReadLine();

            Console.Write("INFORME O CRM DO MÉDICO:.. ");
            exame.medico.Crm = Console.ReadLine();

            Console.Write("INFORME O TIPO DO EXAME:.. ");
            exame.Tipo = Console.ReadLine();

            Console.Write("INFORME O RESULTADO DO EXAME:.. ");
            exame.Resultado = Console.ReadLine();
            Console.WriteLine("...");

            var exameRepositoryXml = new ExameRespositoryXML();
            exameRepositoryXml.Exportar(exame);

            Console.WriteLine("\n EXAME CADASTRADO COM SUCESSO! \n");

        }


    }
}
