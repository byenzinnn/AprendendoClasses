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

        int i = 0;
        Aluno[] aluno = new Aluno[10];

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
                aluno[i] = new Aluno();
                aluno[i].setNome(txtNome.Text);
                aluno[i].setSexo(txtSexo.Text);
                aluno[i].setCurso(cmbCurso.Text);
                aluno[i].setNota1(int.Parse(txtNota1.Text));
                aluno[i].setNota2(int.Parse(txtNota2.Text));
                aluno[i].setDtNasc(dtmDtNasc.Value);
                aluno[i].setMensalidade(Convert.ToInt32(txtMensalidade.Text));
                
                lblClasse.Text = ("Nome: " + aluno[i].getNome());
                lblClasse.Text += ("\nData de nascimento: " + aluno[i].getDtNasc());
                lblClasse.Text += ("\nSexo: " + aluno[i].getSexo());
                lblClasse.Text += ("\nCurso: " + aluno[i].getCurso());
                lblClasse.Text += ("\nNota 1: " + aluno[i].getNota1());
                lblClasse.Text += ("\nNota 2: " + aluno[i].getNota2());
                aluno[i].mediaCalc();
                lblClasse.Text += ("\nMedia: " + aluno[i].getMedia());
                lblClasse.Text += ("\nMensalidade: " + aluno[i].getMensalidade());


            } catch(FormatException)
            {
                MessageBox.Show("Erro de inclusão");
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
