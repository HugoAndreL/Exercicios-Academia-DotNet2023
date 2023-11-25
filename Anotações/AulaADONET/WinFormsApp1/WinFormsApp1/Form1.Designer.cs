namespace Teste_ADONET
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
            dvPessoas = new DataGridView();
            btnConsulta = new Button();
            gbCadastro = new GroupBox();
            btnCadastrar = new Button();
            tbIdade = new TextBox();
            tbNome = new TextBox();
            lbIdade = new Label();
            lbNome = new Label();
            ((System.ComponentModel.ISupportInitialize)dvPessoas).BeginInit();
            gbCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // dvPessoas
            // 
            dvPessoas.AllowUserToAddRows = false;
            dvPessoas.AllowUserToDeleteRows = false;
            dvPessoas.BackgroundColor = SystemColors.ControlDarkDark;
            dvPessoas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvPessoas.Location = new Point(12, 12);
            dvPessoas.Name = "dvPessoas";
            dvPessoas.ReadOnly = true;
            dvPessoas.Size = new Size(367, 198);
            dvPessoas.TabIndex = 0;
            // 
            // btnConsulta
            // 
            btnConsulta.BackColor = Color.LightSeaGreen;
            btnConsulta.Cursor = Cursors.Hand;
            btnConsulta.FlatAppearance.BorderColor = Color.Teal;
            btnConsulta.FlatAppearance.BorderSize = 3;
            btnConsulta.FlatStyle = FlatStyle.Flat;
            btnConsulta.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsulta.ForeColor = Color.DarkCyan;
            btnConsulta.Location = new Point(12, 216);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(367, 62);
            btnConsulta.TabIndex = 1;
            btnConsulta.Text = "Consutar";
            btnConsulta.UseVisualStyleBackColor = false;
            btnConsulta.Click += Consultar;
            // 
            // gbCadastro
            // 
            gbCadastro.BackColor = Color.Transparent;
            gbCadastro.Controls.Add(btnCadastrar);
            gbCadastro.Controls.Add(tbIdade);
            gbCadastro.Controls.Add(tbNome);
            gbCadastro.Controls.Add(lbIdade);
            gbCadastro.Controls.Add(lbNome);
            gbCadastro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gbCadastro.ForeColor = SystemColors.WindowText;
            gbCadastro.Location = new Point(385, 12);
            gbCadastro.Name = "gbCadastro";
            gbCadastro.Size = new Size(403, 266);
            gbCadastro.TabIndex = 3;
            gbCadastro.TabStop = false;
            gbCadastro.Text = "Cadastro";
            // 
            // btnCadastrar
            // 
            btnCadastrar.FlatStyle = FlatStyle.System;
            btnCadastrar.ForeColor = SystemColors.WindowText;
            btnCadastrar.Location = new Point(6, 204);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(71, 56);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Adicionar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += AddPessoa;
            // 
            // tbIdade
            // 
            tbIdade.Cursor = Cursors.IBeam;
            tbIdade.Location = new Point(56, 91);
            tbIdade.Name = "tbIdade";
            tbIdade.PlaceholderText = "Digite a idade da pessoa";
            tbIdade.Size = new Size(325, 23);
            tbIdade.TabIndex = 3;
            // 
            // tbNome
            // 
            tbNome.Cursor = Cursors.IBeam;
            tbNome.Location = new Point(57, 37);
            tbNome.Name = "tbNome";
            tbNome.PlaceholderText = "Digite o nome da pessoa";
            tbNome.Size = new Size(324, 23);
            tbNome.TabIndex = 2;
            // 
            // lbIdade
            // 
            lbIdade.AutoSize = true;
            lbIdade.Location = new Point(11, 94);
            lbIdade.Name = "lbIdade";
            lbIdade.Size = new Size(41, 15);
            lbIdade.TabIndex = 1;
            lbIdade.Text = "Idade:";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(11, 40);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(44, 15);
            lbNome.TabIndex = 0;
            lbNome.Text = "Nome:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 290);
            Controls.Add(gbCadastro);
            Controls.Add(btnConsulta);
            Controls.Add(dvPessoas);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dvPessoas).EndInit();
            gbCadastro.ResumeLayout(false);
            gbCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dvPessoas;
        private Button btnConsulta;
        private TextBox textBox1;
        private GroupBox gbCadastro;
        private TextBox tbNome;
        private Label lbIdade;
        private Label lbNome;
        private Button btnCadastrar;
        private TextBox tbIdade;
    }
}
