namespace MiniERP
{
    partial class Prod
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
            dgvTableProd = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbId = new TextBox();
            tbNome = new TextBox();
            tbForn = new TextBox();
            tbPreco = new TextBox();
            label5 = new Label();
            tbDesc = new TextBox();
            btnAdd = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTableProd).BeginInit();
            SuspendLayout();
            // 
            // dgvTableProd
            // 
            dgvTableProd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTableProd.Location = new Point(12, 500);
            dgvTableProd.Name = "dgvTableProd";
            dgvTableProd.RowTemplate.Height = 25;
            dgvTableProd.Size = new Size(776, 356);
            dgvTableProd.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 1;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Titulo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 90);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 3;
            label3.Text = "Fornecedor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 134);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 4;
            label4.Text = "Preço:";
            // 
            // tbId
            // 
            tbId.Location = new Point(39, 8);
            tbId.Name = "tbId";
            tbId.PlaceholderText = "Este campo só será considerado caso algum campo seja procurado, atualizado ou deletado ";
            tbId.Size = new Size(749, 23);
            tbId.TabIndex = 5;
            // 
            // tbNome
            // 
            tbNome.Location = new Point(58, 44);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(730, 23);
            tbNome.TabIndex = 6;
            // 
            // tbForn
            // 
            tbForn.Location = new Point(88, 87);
            tbForn.Name = "tbForn";
            tbForn.PlaceholderText = "Id do Fornecedor";
            tbForn.Size = new Size(700, 23);
            tbForn.TabIndex = 7;
            // 
            // tbPreco
            // 
            tbPreco.HideSelection = false;
            tbPreco.Location = new Point(58, 131);
            tbPreco.Name = "tbPreco";
            tbPreco.Size = new Size(730, 23);
            tbPreco.TabIndex = 8;
            tbPreco.KeyPress += Decimal;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 169);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 9;
            label5.Text = "Descrição:";
            // 
            // tbDesc
            // 
            tbDesc.Location = new Point(79, 166);
            tbDesc.Multiline = true;
            tbDesc.Name = "tbDesc";
            tbDesc.Size = new Size(709, 245);
            tbDesc.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(12, 423);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(138, 65);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Inserir";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += Add;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(165, 423);
            button1.Name = "button1";
            button1.Size = new Size(138, 65);
            button1.TabIndex = 13;
            button1.Text = "Consultar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Read;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(650, 423);
            button2.Name = "button2";
            button2.Size = new Size(138, 65);
            button2.TabIndex = 14;
            button2.Text = "Deletar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Delete;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(320, 423);
            button3.Name = "button3";
            button3.Size = new Size(161, 65);
            button3.TabIndex = 15;
            button3.Text = "Procurar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Search;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(498, 423);
            button4.Name = "button4";
            button4.Size = new Size(135, 65);
            button4.TabIndex = 16;
            button4.Text = "Atualizar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Update;
            // 
            // Prod
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 868);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnAdd);
            Controls.Add(tbDesc);
            Controls.Add(label5);
            Controls.Add(tbPreco);
            Controls.Add(tbForn);
            Controls.Add(tbNome);
            Controls.Add(tbId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvTableProd);
            Name = "Prod";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prod";
            ((System.ComponentModel.ISupportInitialize)dgvTableProd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTableProd;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbId;
        private TextBox tbNome;
        private TextBox tbForn;
        private TextBox tbPreco;
        private Label label5;
        private TextBox tbDesc;
        private Button btnAdd;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}