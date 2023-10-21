using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoClasses
{
    internal class Animal
    {
        public string nome, cor, racao;
        private DateTime dtNasc, dtObito;
        private float peso, preco;
        private Boolean castrado;

        public Animal()
        {
            this.cor = "";
            this.racao = "";
            this.nome = "";
            this.preco = 0;
            this.peso = 0;
            this.dtNasc = DateTime.Today;
            this.dtObito = DateTime.Today;
            this.castrado = false;
        }

        public void setCor(string cor)
        {
            this.cor = cor;
        }

        public  string getCor()
        {
            return this.cor;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        
        public string getNome()
        {
            return this.nome;
        }

        public void setRacao(string racao)
        {
            this.racao = racao;
        }

        public string getRacao()
        {
            return this.racao;
        }

        public void setPreco(float preco)
        {
            this.preco = preco;
        }

        public float getPreco()
        {
            return this.preco;
        }

        public void setPeso(float peso)
        {
            this.peso = peso;
        }

        public float getPeso()
        {
            return this.peso;
        }

        public void setDtNasc(DateTime dtNasc)
        {
            this.dtNasc = dtNasc;
        }

        public DateTime getDtNasc()
        {
            return this.dtNasc;
        }

        public void setDtObito(DateTime dtObito)
        {
            this.dtObito = dtObito;
        }

        public DateTime getDtObito()
        {
            return this.dtObito;
        }

        public void setCastrado(Boolean castrado)
        {
            this.castrado = castrado;
        }

        public Boolean getCastrado()
        {
            return this.castrado;
        }

    }
}
