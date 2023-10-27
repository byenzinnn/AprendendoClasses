using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AprendendoClasses
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //Criando objeto carro
        int i;
        Carro[] objCarro = new Carro[10]; // Chamada

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClasseCarro_Click(object sender, EventArgs e)
        {
            try
            {
                objCarro[i] = new Carro();
                // Atribui valor aos atributos com os set's
                objCarro[i].setPlaca(txtPlaca.Text);
                objCarro[i].setCor(cmbCorCarro.Text);
                objCarro[i].setCombustivel(txtCombustivel.Text);
                objCarro[i].setDataCompra(dtpDataCompra.Value);
                objCarro[i].setMarca(txtMarca.Text);
                objCarro[i].setPreco(Convert.ToDouble(txtPreco.Text));
                objCarro[i].setNumBatidas(Convert.ToInt16(txtNumBatidas.Text));

                // Acessando os metodos get
                lblClasse.Text = ("Placa: " + objCarro[i].getPlaca());
                lblClasse.Text += ("\nModelo: " + objCarro[i].getMarca());
                lblClasse.Text += ("\nCor: " + objCarro[i].getCor());
                objCarro[i].sumValor();
                lblClasse.Text += ("\nPreço: " + objCarro[i].getPreco());
                lblClasse.Text += ("\nData Compra : " + objCarro[i].getDataCompra());
                lblClasse.Text += ("\nNum batidas : " + objCarro[i].getNumBatidas());
                lblClasse.Text += ("\nMarca : " + objCarro[i].getMarca());

                }

            catch (FormatException){
                MessageBox.Show("Erro de inclusão");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 um = new Form1();
            this.Hide();
            um.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                objCarro[i] = new Carro();

                // Atribui valor aos atributos com os set's
                objCarro[i].setPlaca(txtPlaca.Text);
                objCarro[i].setCor(cmbCorCarro.Text);
                objCarro[i].setCombustivel(txtCombustivel.Text);
                objCarro[i].setDataCompra(dtpDataCompra.Value);
                objCarro[i].setMarca(txtMarca.Text);
                objCarro[i].setPreco(Convert.ToDouble(txtPreco.Text));
                objCarro[i].setNumBatidas(Convert.ToInt16(txtNumBatidas.Text));

                // Acessando os metodos get
                lblClasse.Text = ("Placa: " + objCarro[i].getPlaca());
                lblClasse.Text += ("\nModelo: " + objCarro[i].getMarca());
                lblClasse.Text += ("\nCor: " + objCarro[i].getCor());
                objCarro[i].sumValor();
                lblClasse.Text += ("\nPreço: " +  objCarro[i].getPreco());
                lblClasse.Text += ("\nData Compra : " + objCarro[i].getDataCompra());
                lblClasse.Text += ("\nNum batidas : " + objCarro[i].getNumBatidas());
                lblClasse.Text += ("\nMarca : " + objCarro[i].getMarca());


            }

            catch (FormatException)
            {
                MessageBox.Show("Erro de inclusão");
            }
        }
    }
}
