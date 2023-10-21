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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        Animal animal = new Animal();

        int op;
        bool cast;

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 um = new Form1();
            this.Hide();
            um.Show();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            try
            {
                    animal.setNome(txtNomeAnimal.Text);
                    animal.setCor(txtCor.Text);
                    animal.setRacao(txtRacao.Text);
                    animal.setPeso(Convert.ToInt32(txtPesoAnimal.Text));
                    animal.setDtNasc(dtpDataNascimento.Value);
                    animal.setDtObito(dtpDataObito.Value);
                    animal.setPreco(Convert.ToInt32(txtPreco.Text));

                if (txtCastrado.Text == "ss" || txtCastrado.Text == "s" || txtCastrado.Text == "sim")
                {

                    lblClasseAnimal.Text = ("Nome: " + animal.getNome());
                    lblClasseAnimal.Text += ("\nCor : " + animal.getCor());
                    lblClasseAnimal.Text += ("\nRação : " + animal.getRacao());
                    lblClasseAnimal.Text += ("\nPeso : " + animal.getPeso());
                    lblClasseAnimal.Text += ("\nPreço : " + animal.getPreco());
                    lblClasseAnimal.Text += ("\nNascimento : " + animal.getDtNasc());
                    lblClasseAnimal.Text += ("\nObito : " + animal.getDtObito());
                    lblClasseAnimal.Text += ("\nCastrado");


                }
                else if (txtCastrado.Text == "nn" || txtCastrado.Text == "n" || txtCastrado.Text == "nao" || txtCastrado.Text == "não")
                {
                    lblClasseAnimal.Text = ("Nome: " + animal.getNome());
                    lblClasseAnimal.Text += ("\nCor : " + animal.getCor());
                    lblClasseAnimal.Text += ("\nRação : " + animal.getRacao());
                    lblClasseAnimal.Text += ("\nPeso : " + animal.getPeso());
                    lblClasseAnimal.Text += ("\nPreço : " + animal.getPreco());
                    lblClasseAnimal.Text += ("\nNascimento : " + animal.getDtNasc());
                    lblClasseAnimal.Text += ("\nObito : " + animal.getDtObito());
                    lblClasseAnimal.Text += ("\nNão é castrado");
                }
                else
                {
                    MessageBox.Show("Escreva sim ou não");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro de inclusão");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
