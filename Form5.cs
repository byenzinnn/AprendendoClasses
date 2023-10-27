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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        int i = 0;

        Imovel[] imovel = new Imovel[10];

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void btnCadastrarImovel_Click(object sender, EventArgs e)
        {
            try
            {
                imovel[i] = new Imovel();
                imovel[i].setNumero(int.Parse(txtNum.Text));
                imovel[i].setEmpresa(txtEmpresa.Text);
                imovel[i].setCep(int.Parse(txtCep.Text));
                imovel[i].setDataCompra(DateTime.Now);
                imovel[i].setPais(cmbPais.Text);
                imovel[i].setEstado(cmbEstado.Text);
                imovel[i].setCidade(cmbCidade.Text);

                lblClasse.Text = ("Numero: " + imovel[i].getNumero());
                lblClasse.Text += ("\nCEP: " + imovel[i].getCep());
                lblClasse.Text += ("\nEmpresa: "+ imovel[i].getEmpresa());
                lblClasse.Text += ("\nData de compra: " + imovel[i].getDataCompra());
                lblClasse.Text += ("\nPais: " + imovel[i].getPais());
                lblClasse.Text += ("\nEstado: " + imovel[i].getEstado());
                lblClasse.Text += ("\nCidade: " + imovel[i].getCidade());

            } catch(FormatException) {
                MessageBox.Show("Erro de inclusão");
            }

            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 um = new Form1();
            this.Hide();
            um.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbPais.SelectedIndex == 0)
            {
                cmbEstado.Visible = true;
                lblEstado.Visible = true;
                cmbEstado.Text = "";

                cmbEstado.Items.Clear();
                cmbEstado.Items.Add("São Paulo");
                cmbEstado.Items.Add("Santa Catarina");
            }
            else if(cmbPais.SelectedIndex == 1)
            {
                cmbEstado.Visible = true;
                lblEstado.Visible = true;
                cmbEstado.Text = "";

                cmbEstado.Items.Clear();
                cmbEstado.Items.Add("New York");
                cmbEstado.Items.Add("California");

            }
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbEstado.SelectedIndex == 0 && cmbPais.SelectedIndex == 0)
            {
                cmbCidade.Visible = true;
                lblCidade.Visible = true;

                cmbCidade.Items.Clear();
            }
            
        }
    }
}
