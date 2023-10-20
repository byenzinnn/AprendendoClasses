namespace AprendendoClasses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnClasseCarro_Click(object sender, EventArgs e)
        {
            Form2 dois = new Form2();
            this.Hide();
            dois.Show();
        }

        private void btnCadastrarCachorros_Click(object sender, EventArgs e)
        {
            Form3 tres = new Form3();
            this.Hide();
            tres.Show();
        }

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            Form4 quatro = new Form4();
            this.Hide();
            quatro.Show();
        }
    }
}