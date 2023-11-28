namespace MiniERP
{
    partial class Forn
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
            dgvTableForn = new DataGridView();
            label1 = new Label();
            tbNome = new TextBox();
            btnAdd = new Button();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            tbDatCriacao = new TextBox();
            tbDesc = new TextBox();
            tbCNPJ = new TextBox();
            btnRead = new Button();
            btnSearch = new Button();
            btnUpdate = new Button();
            label4 = new Label();
            tbId = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTableForn).BeginInit();
            SuspendLayout();
            // 
            // dgvTableForn
            // 
            dgvTableForn.AllowUserToAddRows = false;
            dgvTableForn.AllowUserToDeleteRows = false;
            dgvTableForn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTableForn.Location = new Point(12, 509);
            dgvTableForn.Name = "dgvTableForn";
            dgvTableForn.ReadOnly = true;
            dgvTableForn.RowTemplate.Height = 25;
            dgvTableForn.Size = new Size(776, 347);
            dgvTableForn.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 56);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome:";
            // 
            // tbNome
            // 
            tbNome.Location = new Point(61, 53);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(727, 23);
            tbNome.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(12, 429);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(138, 65);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Inserir";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += AddForn;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 137);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 4;
            label2.Text = "Descrição:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 5;
            label3.Text = "CNPJ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 393);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 7;
            label5.Text = "Data de Criação:";
            // 
            // tbDatCriacao
            // 
            tbDatCriacao.Location = new Point(111, 390);
            tbDatCriacao.Name = "tbDatCriacao";
            tbDatCriacao.Size = new Size(677, 23);
            tbDatCriacao.TabIndex = 9;
            // 
            // tbDesc
            // 
            tbDesc.Location = new Point(79, 134);
            tbDesc.Multiline = true;
            tbDesc.Name = "tbDesc";
            tbDesc.Size = new Size(709, 237);
            tbDesc.TabIndex = 10;
            // 
            // tbCNPJ
            // 
            tbCNPJ.Location = new Point(55, 94);
            tbCNPJ.Name = "tbCNPJ";
            tbCNPJ.Size = new Size(733, 23);
            tbCNPJ.TabIndex = 11;
            // 
            // btnRead
            // 
            btnRead.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnRead.Location = new Point(162, 429);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(138, 65);
            btnRead.TabIndex = 12;
            btnRead.Text = "Consultar";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += Read;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(317, 429);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(161, 65);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Procurar";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += Search;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(494, 429);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(138, 65);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Atualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += Update;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 15);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 15;
            label4.Text = "ID:";
            // 
            // tbId
            // 
            tbId.Location = new Point(39, 12);
            tbId.Name = "tbId";
            tbId.PlaceholderText = "Este campo só será considerado caso algum campo seja procurado, atualizado ou deletado ";
            tbId.Size = new Size(749, 23);
            tbId.TabIndex = 16;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(650, 429);
            button2.Name = "button2";
            button2.Size = new Size(138, 65);
            button2.TabIndex = 18;
            button2.Text = "Deletar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Delete;
            // 
            // Forn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 868);
            Controls.Add(button2);
            Controls.Add(tbId);
            Controls.Add(label4);
            Controls.Add(btnUpdate);
            Controls.Add(btnSearch);
            Controls.Add(btnRead);
            Controls.Add(tbCNPJ);
            Controls.Add(tbDesc);
            Controls.Add(tbDatCriacao);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAdd);
            Controls.Add(tbNome);
            Controls.Add(label1);
            Controls.Add(dgvTableForn);
            Name = "Forn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fornecedor";
            Click += Delete;
            ((System.ComponentModel.ISupportInitialize)dgvTableForn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTableForn;
        private Label label1;
        private TextBox tbNome;
        private Button btnAdd;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox tbDatCriacao;
        private TextBox tbDesc;
        private TextBox tbCNPJ;
        private Button btnRead;
        private Button btnSearch;
        private Button btnUpdate;
        private Label label4;
        private TextBox tbId;
        private Button button2;
    }
}