using System;
using System.Collections.Generic;

namespace atividadeAlunoMedia
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Quantos alunos serão cadastrados? ");
            int qtdeCadastros = Convert.ToInt32(Console.ReadLine());

            List<Aluno> alunos = new List<Aluno>();

            for (int i = 0; i < qtdeCadastros; i++)
            {
                var aluno = new Aluno();
                
                Console.WriteLine("Dados do " + (i + 1) + "º aluno: ");

                Console.Write("Nome: ");
                aluno.Nome = (Console.ReadLine());
                Console.Write("Matrícula: ");
                aluno.Matricula = Console.ReadLine();
                Console.Write("Primeira nota: ");
                aluno.Notas.Add(Convert.ToDouble(Console.ReadLine()));
                Console.Write("Segunda nota: ");
                aluno.Notas.Add(Convert.ToDouble(Console.ReadLine()));
                Console.Write("Terceira nota: ");
                aluno.Notas.Add(Convert.ToDouble(Console.ReadLine()));
                Console.Write("Quarta nota: ");
                aluno.Notas.Add(Convert.ToDouble(Console.ReadLine()));
                Console.Clear();

                alunos.Add(aluno);
                Console.WriteLine();
            }

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno.ToString());
            }

            Console.ReadKey();
        }
    }
}