namespace AprendendoClasses
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClasseCarro = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCadastrarAnimal = new System.Windows.Forms.Button();
            this.btnCadastrarAluno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClasseCarro
            // 
            this.btnClasseCarro.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClasseCarro.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClasseCarro.Location = new System.Drawing.Point(85, 136);
            this.btnClasseCarro.Name = "btnClasseCarro";
            this.btnClasseCarro.Size = new System.Drawing.Size(194, 154);
            this.btnClasseCarro.TabIndex = 0;
            this.btnClasseCarro.Text = "Cadastrar Carros";
            this.btnClasseCarro.UseVisualStyleBackColor = false;
            this.btnClasseCarro.Click += new System.EventHandler(this.btnClasseCarro_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSair.Location = new System.Drawing.Point(685, 384);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(103, 54);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCadastrarAnimal
            // 
            this.btnCadastrarAnimal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrarAnimal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarAnimal.Location = new System.Drawing.Point(285, 136);
            this.btnCadastrarAnimal.Name = "btnCadastrarAnimal";
            this.btnCadastrarAnimal.Size = new System.Drawing.Size(194, 154);
            this.btnCadastrarAnimal.TabIndex = 2;
            this.btnCadastrarAnimal.Text = "Cadastrar Animal";
            this.btnCadastrarAnimal.UseVisualStyleBackColor = false;
            this.btnCadastrarAnimal.Click += new System.EventHandler(this.btnCadastrarCachorros_Click);
            // 
            // btnCadastrarAluno
            // 
            this.btnCadastrarAluno.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrarAluno.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarAluno.Location = new System.Drawing.Point(485, 136);
            this.btnCadastrarAluno.Name = "btnCadastrarAluno";
            this.btnCadastrarAluno.Size = new System.Drawing.Size(194, 154);
            this.btnCadastrarAluno.TabIndex = 3;
            this.btnCadastrarAluno.Text = "Cadastrar Aluno";
            this.btnCadastrarAluno.UseVisualStyleBackColor = false;
            this.btnCadastrarAluno.Click += new System.EventHandler(this.btnCadastrarAluno_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastrarAluno);
            this.Controls.Add(this.btnCadastrarAnimal);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnClasseCarro);
            this.Name = "Form1";
            this.Text = "Exemplo de Classe";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnClasseCarro;
        private Button btnSair;
        private Button btnCadastrarAnimal;
        private Button btnCadastrarAluno;
    }
}