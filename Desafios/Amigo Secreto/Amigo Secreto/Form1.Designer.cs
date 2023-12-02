namespace Amigo_Secreto
{
    partial class frmAmigoSecreto
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAmigoSecreto));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            menuAmigoSecreto = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            menuLimpar = new ToolStripMenuItem();
            menuAdd = new ToolStripMenuItem();
            menuAjuda = new ToolStripMenuItem();
            menuSobre = new ToolStripMenuItem();
            lblNome = new Label();
            tbName = new TextBox();
            scButton = new SplitContainer();
            btnAdd = new Button();
            btnClear = new Button();
            lblCounter = new Label();
            dgvLst = new DataGridView();
            colEmail = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            friendBindingSource = new BindingSource(components);
            menuAmigoSecreto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scButton).BeginInit();
            scButton.Panel1.SuspendLayout();
            scButton.Panel2.SuspendLayout();
            scButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLst).BeginInit();
            ((System.ComponentModel.ISupportInitialize)friendBindingSource).BeginInit();
            SuspendLayout();
            // 
            // menuAmigoSecreto
            // 
            menuAmigoSecreto.BackColor = Color.LightCoral;
            menuAmigoSecreto.Items.AddRange(new ToolStripItem[] { menuFile, menuAjuda });
            menuAmigoSecreto.Location = new Point(0, 0);
            menuAmigoSecreto.Name = "menuAmigoSecreto";
            menuAmigoSecreto.Size = new Size(1197, 24);
            menuAmigoSecreto.TabIndex = 0;
            // 
            // menuFile
            // 
            menuFile.BackColor = Color.LightCoral;
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuLimpar, menuAdd });
            menuFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            menuFile.ForeColor = Color.Firebrick;
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(51, 20);
            menuFile.Text = "Menu";
            // 
            // menuLimpar
            // 
            menuLimpar.ForeColor = Color.Firebrick;
            menuLimpar.Name = "menuLimpar";
            menuLimpar.Size = new Size(163, 22);
            menuLimpar.Text = "Cadastrar amigo";
            menuLimpar.Click += Add;
            // 
            // menuAdd
            // 
            menuAdd.ForeColor = Color.ForestGreen;
            menuAdd.Name = "menuAdd";
            menuAdd.Size = new Size(163, 22);
            menuAdd.Text = "Limpar lista";
            menuAdd.Click += Clear;
            // 
            // menuAjuda
            // 
            menuAjuda.DropDownItems.AddRange(new ToolStripItem[] { menuSobre });
            menuAjuda.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            menuAjuda.ForeColor = Color.Firebrick;
            menuAjuda.Name = "menuAjuda";
            menuAjuda.Size = new Size(50, 20);
            menuAjuda.Text = "Ajuda";
            // 
            // menuSobre
            // 
            menuSobre.ForeColor = Color.Turquoise;
            menuSobre.Name = "menuSobre";
            menuSobre.Size = new Size(107, 22);
            menuSobre.Text = "Sobre";
            menuSobre.Click += About;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.ForeColor = Color.White;
            lblNome.Location = new Point(12, 35);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(101, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome Completo:";
            // 
            // tbName
            // 
            tbName.BackColor = SystemColors.Info;
            tbName.Location = new Point(119, 32);
            tbName.MaxLength = 30;
            tbName.Name = "tbName";
            tbName.PlaceholderText = "Digite seu nome completo";
            tbName.Size = new Size(540, 23);
            tbName.TabIndex = 2;
            // 
            // scButton
            // 
            scButton.BackColor = Color.Transparent;
            scButton.Location = new Point(12, 78);
            scButton.Name = "scButton";
            // 
            // scButton.Panel1
            // 
            scButton.Panel1.BackColor = Color.Transparent;
            scButton.Panel1.Controls.Add(btnAdd);
            // 
            // scButton.Panel2
            // 
            scButton.Panel2.BackColor = Color.Transparent;
            scButton.Panel2.Controls.Add(btnClear);
            scButton.Size = new Size(722, 77);
            scButton.SplitterDistance = 363;
            scButton.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.AccessibleName = "Adicionar";
            btnAdd.BackColor = SystemColors.Info;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.Location = new Point(133, 0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(84, 77);
            btnAdd.TabIndex = 0;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += Add;
            // 
            // btnClear
            // 
            btnClear.AccessibleName = "Limpar";
            btnClear.BackColor = SystemColors.Info;
            btnClear.Cursor = Cursors.Hand;
            btnClear.Image = (Image)resources.GetObject("btnClear.Image");
            btnClear.Location = new Point(135, 0);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(84, 77);
            btnClear.TabIndex = 0;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += Clear;
            // 
            // lblCounter
            // 
            lblCounter.AutoSize = true;
            lblCounter.BackColor = Color.Transparent;
            lblCounter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCounter.ForeColor = Color.White;
            lblCounter.Location = new Point(665, 35);
            lblCounter.Name = "lblCounter";
            lblCounter.Size = new Size(69, 15);
            lblCounter.TabIndex = 9;
            lblCounter.Text = "Contator: 0";
            // 
            // dgvLst
            // 
            dgvLst.AllowUserToAddRows = false;
            dgvLst.AllowUserToDeleteRows = false;
            dgvLst.AutoGenerateColumns = false;
            dgvLst.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dgvLst.BackgroundColor = SystemColors.Window;
            dgvLst.CausesValidation = false;
            dgvLst.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Bisque;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Bisque;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLst.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLst.ColumnHeadersHeight = 25;
            dgvLst.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvLst.Columns.AddRange(new DataGridViewColumn[] { colEmail, colName });
            dgvLst.DataSource = friendBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvLst.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLst.EnableHeadersVisualStyles = false;
            dgvLst.GridColor = SystemColors.ActiveBorder;
            dgvLst.Location = new Point(12, 174);
            dgvLst.Name = "dgvLst";
            dgvLst.ReadOnly = true;
            dgvLst.RightToLeft = RightToLeft.Yes;
            dgvLst.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Info;
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Firebrick;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dgvLst.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvLst.RowTemplate.Height = 25;
            dgvLst.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLst.ShowEditingIcon = false;
            dgvLst.Size = new Size(722, 598);
            dgvLst.TabIndex = 10;
            // 
            // colEmail
            // 
            colEmail.DataPropertyName = "Email";
            colEmail.Frozen = true;
            colEmail.HeaderText = "Email";
            colEmail.MaxInputLength = 50;
            colEmail.MinimumWidth = 100;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            colEmail.Resizable = DataGridViewTriState.False;
            colEmail.Width = 340;
            // 
            // colName
            // 
            colName.DataPropertyName = "Name";
            colName.Frozen = true;
            colName.HeaderText = "Name";
            colName.MinimumWidth = 100;
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Resizable = DataGridViewTriState.False;
            colName.Width = 340;
            // 
            // friendBindingSource
            // 
            friendBindingSource.DataSource = typeof(Friend);
            // 
            // frmAmigoSecreto
            // 
            AutoValidate = AutoValidate.Disable;
            BackColor = SystemColors.Window;
            BackgroundImage = Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1197, 784);
            Controls.Add(dgvLst);
            Controls.Add(lblCounter);
            Controls.Add(scButton);
            Controls.Add(tbName);
            Controls.Add(lblNome);
            Controls.Add(menuAmigoSecreto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuAmigoSecreto;
            MaximizeBox = false;
            Name = "frmAmigoSecreto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Amigo Secreto";
            menuAmigoSecreto.ResumeLayout(false);
            menuAmigoSecreto.PerformLayout();
            scButton.Panel1.ResumeLayout(false);
            scButton.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scButton).EndInit();
            scButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLst).EndInit();
            ((System.ComponentModel.ISupportInitialize)friendBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private MenuStrip menuAmigoSecreto;
        private ToolStripMenuItem menuFile;
        private ToolStripMenuItem menuAjuda;
        private ToolStripMenuItem menuAdd;
        private ToolStripMenuItem menuSobre;
        private Label lblNome;
        private TextBox tbName;
        private SplitContainer scButton;
        private Button btnAdd;
        private Button btnClear;
        private ToolStripMenuItem menuLimpar;
        private Label lblCounter;
        private DataGridView dgvLst;
        private BindingSource friendBindingSource;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colName;
    }
}