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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        Aluno aluno = new Aluno();

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 um = new Form1();
            this.Hide();
            um.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtpDataCompra_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            try
            {
                aluno.setNome(txtNome.Text);

            } catch(FormatException)
            {
                MessageBox.Show("Erro de inclusão");
            }
        }
    }
}
