using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoClasses
{
    internal class Aluno
    {
        public string nome { get; set; }
        public string sexo { get; set; }
        public CheckBox curso { get; set; }
        public int nota1 { get; set; }
        public int nota2 { get; set; }
        public int media { get; set; }
        public float mensalidade { get; set; }
        public DateTime dtNasc { get; set; }

        public Aluno()
        {
            this.nome = nome;
            this.sexo = "";
            this.curso = curso;
            this.nota1 = 0;
            this.nota2 = 0;
            this.media = 0;
            this.mensalidade = 0;
            this.dtNasc = DateTime.Today;
        }
    }
}

