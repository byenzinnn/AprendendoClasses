using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AprendendoClasses
{
    internal class Aluno
    {
        public string nome;
        public string sexo;
        public string curso;
        public float nota1;
        public float nota2;
        public float media;
        public float mensalidade;
        public DateTime dtNasc;

        public Aluno()
        {
            this.nome = "";
            this.sexo = "";
            this.curso = "";
            this.nota1 = 0;
            this.nota2 = 0;
            this.media = (nota1 + nota2) / 2;
            this.mensalidade = 0;
            this.dtNasc = DateTime.Today;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setSexo(string sexo)
        {
            this.sexo = sexo;
        }

        public string getSexo()
        {
            return this.sexo;
        }

        public void setCurso(string curso)
        {
            this.curso = curso;
        }

        public string getCurso()
        {
            return this.curso;
        }

        public void setNota1(int nota1)
        {
            this.nota1 = nota1;
        }

        public float getNota1()
        {
            return this.nota1;
        }

        public void setNota2(int nota2)
        {
            this.nota2 = nota2;
        }

        public float getNota2()
        {
            return this.nota2;
        }

        public void setMedia(float media)
        {
            this.media = media;
        }

        public float getMedia()
        {
            return this.media;
        }

        public void setMensalidade(int mensalidade)
        {
            this.mensalidade = mensalidade;
        }

        public float getMensalidade()
        {
            return this.mensalidade;
        }

        public void setDtNasc(DateTime dtNasc)
        {
            this.dtNasc = dtNasc;
        }

        public DateTime getDtNasc()
        {
            return this.dtNasc;
        }

        

        public void mediaCalc()
        {
            this.media = (this.nota1 + this.nota2) / 2;
        }
    }
}

