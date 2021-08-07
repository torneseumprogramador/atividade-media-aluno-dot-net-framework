using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeAlunoMedia
{
    class Aluno : Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }

        public override string FacaAlgoParaSuaFamilia()
        {
            return base.FacaAlgoParaSuaFamilia() + " - O que eu fiz para minha familia";
        }

        private List<double> notas;
        public List<double> Notas
        {
            get
            {
                if (this.notas == null) this.notas = new List<double>();
                return this.notas;
            }
            set
            {
                this.notas = value;
            }
        }

        public double Media()
        {
            double somaNotas = 0;
            foreach(var nota in this.Notas)
            {
                somaNotas += nota;
            }

            return somaNotas / this.Notas.Count;
        }

        public string Situacao()
        {
            return this.Media() >= 7 ? "Aprovado" : "Reprovado";
        }

        public override string ToString()
        {
            string verAluno = "-----------------------------\n";
            verAluno += $"Nome: {this.Nome}\n";
            verAluno += $"Matricula: {this.Matricula}\n";
            verAluno += $"Notas: {string.Join(", ", this.Notas.ToArray())}\n";
            verAluno += $"Media: {this.Media()}\n";
            verAluno += $"Situação: {this.Situacao()}\n";

            return verAluno;
        }
    }
}
