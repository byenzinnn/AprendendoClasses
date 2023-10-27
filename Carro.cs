using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoClasses
{
    internal class Carro
    {
        // Declarndo atributos da classe
        public string marca, placa, cor, combustivel;
        private double preco, precoSomado, valFinal;
        private DateTime dataCompra;
        public int tempoUso, numBatidas;

        // Construtor
        public Carro()
        {
            this.marca = "";
            this.placa = "";
            this.cor = "";
            this.preco = 0;
            this.combustivel = "";
            this.dataCompra = DateTime.Today;
            this.tempoUso = 0;
            this.numBatidas = 0;
            this.precoSomado = 100;
            
        }

        // Atribuindo classe Carro: Marca
        public void setMarca(string marca)
        {
            this.marca = marca;
        }

        public string getMarca()
        {
            return this.marca;
        }

        public void setPlaca(string placa)
        {
            this.placa = placa;
        }

        public string getPlaca()
        {
            return this.placa;
        }

        public void setCor(string cor)
        {
            this.cor = cor;
        }

        public string getCor()
        {
            return this.cor;
        }
        
        public void setPreco(double preco)
        {
            this.preco = preco;
        }

        public double getPreco()
        {
            return this.preco;
        }

        public void setCombustivel(string combustivel)
        {
            this.combustivel = combustivel;
        }

        public string getCombustivel()
        {
            return this.combustivel;
        }

        public void setDataCompra(DateTime dataCompra)
        {
            this.dataCompra = dataCompra;
        }

        public DateTime getDataCompra()
        {
            return this.dataCompra;
        }

        public void setTempoUso(int tempoUso)
        {
            this.tempoUso = tempoUso;
        }

        public int getTempoUso()
        {
            return this.tempoUso;
        }

        public void setNumBatidas(int numBatidas)
        {
            this.numBatidas = numBatidas;
        }

        public int getNumBatidas()
        {
            return this.numBatidas;
        }

        public void setPrecoSomado(double precoSomado)
        {
            this.precoSomado = precoSomado;
        }

        public double getPrecoSomado()
        {
            return this.precoSomado;
        }

        public void setValFinal(double valFinal)
        {
            this.valFinal = valFinal;
        }

        public double getValFinal()
        {
            return this.valFinal;
        }

        public void sumValor()
        {
            this.valFinal = this.preco + this.precoSomado;
            this.preco = this.valFinal;
        }
    }
     
}
