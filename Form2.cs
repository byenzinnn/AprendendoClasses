﻿using System;
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}