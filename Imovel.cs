using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoClasses
{
    internal class Imovel
    {
        public string empresa, pais, estado, cidade;
        public int cep, numero;
        public DateTime dataCompra;

        public Imovel()
        {
            this.empresa = empresa;
            this.cep = cep;
            this.numero = numero;
            this.dataCompra = dataCompra;
            this.pais = pais;
            this.estado = estado;
            this.cidade = cidade;
        }

        public void setEmpresa(string empresa)
        {
            this.empresa = empresa;
        }

        public string getEmpresa()
        {
            return this.empresa;
        }

        public void setCep(int cep)
        {
            this.cep = cep;
        }
        public int getCep()
        {
            return this.cep;
        }

        public void setNumero(int numero)
        {
            this.numero = numero;
        }
        public int getNumero()
        {
            return this.numero;
        }

        public void setDataCompra(DateTime dataCompra)
        {
            this.dataCompra = dataCompra;
        }

        public DateTime getDataCompra()
        {
            return this.dataCompra;
        }

        public void setPais(string pais)
        {
            this.pais = pais;
        }

        public string getPais()
        {
            return this.pais;
        }

        public void setEstado(string estado)
        {
            this.estado = estado;
        }

        public string getEstado() { return this.estado; }

        public void setCidade(String cidade)
        {
            this.cidade = cidade;
        }

        public String getCidade()
        {
            return this.cidade;
        }
    }
}
