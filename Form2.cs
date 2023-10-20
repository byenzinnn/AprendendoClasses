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
        Carro objCarro = new Carro(); // Chamada

        int op;

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClasseCarro_Click(object sender, EventArgs e)
        {
            try
            {
                if(op == 1){ 
                    
                    // Atribui valor aos atributos com os set's
                    objCarro.setPlaca(txtPlaca.Text);
                    objCarro.setCor(cmbCorCarro.Text);
                    objCarro.setCombustivel(txtCombustivel.Text);
                    objCarro.setDataCompra(dtpDataCompra.Value);
                    objCarro.setMarca(txtMarca.Text);
                    objCarro.setPreco(Convert.ToDouble(txtPreco.Text));
                    objCarro.setNumBatidas(Convert.ToInt16(txtNumBatidas.Text));

                    // Acessando os metodos get
                    lblClasse.Text = ("Placa: " + objCarro.getPlaca());
                    lblClasse.Text += ("\nModelo: " + objCarro.getMarca());
                    lblClasse.Text += ("\nCor: " + objCarro.getCor());
                    lblClasse.Text += ("\nPreço: " + objCarro.getPreco());

                    op = 0;
                }
                else if (op == 0)
                {
                    lblClasse.Text = "";

                    op = 1;
                }
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
    }
}
