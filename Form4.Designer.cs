﻿namespace AprendendoClasses
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClasse = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCadastrarAluno = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dtmDtNasc = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMensalidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(552, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 54);
            this.button1.TabIndex = 30;
            this.button1.Text = "VOLTAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSair.Location = new System.Drawing.Point(685, 384);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(103, 54);
            this.btnSair.TabIndex = 29;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // cmbCurso
            // 
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Items.AddRange(new object[] {
            "Portugues",
            "Matematica",
            "Fisica",
            "Geografia"});
            this.cmbCurso.Location = new System.Drawing.Point(79, 86);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(121, 23);
            this.cmbCurso.TabIndex = 44;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(93, 192);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(146, 23);
            this.txtNota2.TabIndex = 42;
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(79, 154);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(146, 23);
            this.txtNota1.TabIndex = 41;
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(64, 48);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(146, 23);
            this.txtSexo.TabIndex = 40;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(77, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(146, 23);
            this.txtNome.TabIndex = 38;
            this.txtNome.TextChanged += new System.EventHandler(this.txtPlaca_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(8, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 28);
            this.label6.TabIndex = 36;
            this.label6.Text = "Notas 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(8, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 28);
            this.label5.TabIndex = 35;
            this.label5.Text = "Nota 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(11, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 28);
            this.label4.TabIndex = 34;
            this.label4.Text = "Curso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(11, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 28);
            this.label3.TabIndex = 33;
            this.label3.Text = "Sexo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 28);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblClasse
            // 
            this.lblClasse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClasse.Location = new System.Drawing.Point(529, 200);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(202, 176);
            this.lblClasse.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(528, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(207, 25);
            this.label9.TabIndex = 48;
            this.label9.Text = "CLASSE CADASTRADA:";
            // 
            // btnCadastrarAluno
            // 
            this.btnCadastrarAluno.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrarAluno.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarAluno.Location = new System.Drawing.Point(586, 15);
            this.btnCadastrarAluno.Name = "btnCadastrarAluno";
            this.btnCadastrarAluno.Size = new System.Drawing.Size(202, 94);
            this.btnCadastrarAluno.TabIndex = 47;
            this.btnCadastrarAluno.Text = "Cadastrar Aluno";
            this.btnCadastrarAluno.UseVisualStyleBackColor = false;
            this.btnCadastrarAluno.Click += new System.EventHandler(this.btnCadastrarAluno_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(308, 400);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 28);
            this.label11.TabIndex = 50;
            this.label11.Text = "CLASSE ALUNO";
            // 
            // dtmDtNasc
            // 
            this.dtmDtNasc.Location = new System.Drawing.Point(203, 120);
            this.dtmDtNasc.Name = "dtmDtNasc";
            this.dtmDtNasc.Size = new System.Drawing.Size(200, 23);
            this.dtmDtNasc.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(8, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 28);
            this.label2.TabIndex = 51;
            this.label2.Text = "Data de nascimento:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtMensalidade
            // 
            this.txtMensalidade.Location = new System.Drawing.Point(141, 226);
            this.txtMensalidade.Name = "txtMensalidade";
            this.txtMensalidade.Size = new System.Drawing.Size(146, 23);
            this.txtMensalidade.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(8, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 28);
            this.label7.TabIndex = 53;
            this.label7.Text = "Mensalidade:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(8, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 28);
            this.label8.TabIndex = 55;
            this.label8.Text = "Media:";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMedia.Location = new System.Drawing.Point(77, 254);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(28, 28);
            this.lblMedia.TabIndex = 56;
            this.lblMedia.Text = "....";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMensalidade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtmDtNasc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblClasse);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCadastrarAluno);
            this.Controls.Add(this.cmbCurso);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSair);
            this.Name = "Form4";
            this.Text = "Alunos";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button btnSair;
        private ComboBox cmbCurso;
        private TextBox txtNota2;
        private TextBox txtNota1;
        private TextBox txtSexo;
        private TextBox txtNome;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label lblClasse;
        private Label label9;
        private Button btnCadastrarAluno;
        private Label label11;
        private DateTimePicker dtmDtNasc;
        private Label label2;
        private TextBox txtMensalidade;
        private Label label7;
        private Label label8;
        private Label lblMedia;
    }
}