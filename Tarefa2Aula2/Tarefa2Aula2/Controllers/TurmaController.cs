using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarefa2Aula2.Entities;
using Tarefa2Aula2.Repositoy;

namespace Tarefa2Aula2.Controllers
{
    public class TurmaController
    {
        public void CadastrarTurma()
        {
            Console.WriteLine("\r\n░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗\r\n██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝\r\n██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░\r\n██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░\r\n╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗\r\n░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝\r\n\r\n████████╗██╗░░░██╗██████╗░███╗░░░███╗░█████╗░░██████╗\r\n╚══██╔══╝██║░░░██║██╔══██╗████╗░████║██╔══██╗██╔════╝\r\n░░░██║░░░██║░░░██║██████╔╝██╔████╔██║███████║╚█████╗░\r\n░░░██║░░░██║░░░██║██╔══██╗██║╚██╔╝██║██╔══██║░╚═══██╗\r\n░░░██║░░░╚██████╔╝██║░░██║██║░╚═╝░██║██║░░██║██████╔╝\r\n░░░╚═╝░░░░╚═════╝░╚═╝░░╚═╝╚═╝░░░░░╚═╝╚═╝░░╚═╝╚═════╝░");

            var turma = new Turma()
            {
                IdTurma = Guid.NewGuid(),
                Professor = new Professor()
                {
                    IdProfessor = Guid.NewGuid(),
                    curso = new Curso()
                    {
                        IdCurso = Guid.NewGuid()
                    }


                },

                
            };

            Console.WriteLine("DIGITE O NOME DA TURMA: ");
            turma.Nome = Console.ReadLine();

            Console.WriteLine("DIGITE A DATA INICIO DO CURSO: ");
            turma.DataInicio = Console.ReadLine();

            Console.WriteLine("DIGITE O NOME DO PROFESSOR: ");
            turma.Professor.Nome = Console.ReadLine();

            Console.WriteLine("DIGITE O TELEFONE DO PROFESSOR: ");
            turma.Professor.Telefone = Console.ReadLine();

            Console.WriteLine("DIGITE O EMAIL DO PROFESSOR: ");
            turma.Professor.Email = Console.ReadLine();

            Console.WriteLine("DIGITE O NOME  DO CURSO: ");
            turma.Professor.curso.titulo = Console.ReadLine();

            Console.WriteLine("DIGITE A CARGA HORÁRIA  DO CURSO: ");
            turma.Professor.curso.CargaHoraria = int.Parse(Console.ReadLine());



            var funcionarioRepositoryXml = new TurmaRepositoryXml();

            funcionarioRepositoryXml.Exportar(turma);

            Console.WriteLine("DADOS GRAVADOS COM SUCESSO");




        }

    }
}
