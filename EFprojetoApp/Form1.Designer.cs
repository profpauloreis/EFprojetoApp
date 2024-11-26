namespace EFprojetoApp
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
            menuStrip1 = new MenuStrip();
            ficheiroToolStripMenuItem = new ToolStripMenuItem();
            atualizarToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnAdicionar = new ToolStripButton();
            btnAtualizar = new ToolStripButton();
            btnRemover = new ToolStripButton();
            btnLimpar = new ToolStripButton();
            dataGridViewSocios = new DataGridView();
            groupBox1 = new GroupBox();
            dtpDataDeEntrada = new DateTimePicker();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            txtNumero = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSocios).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ficheiroToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1262, 40);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ficheiroToolStripMenuItem
            // 
            ficheiroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { atualizarToolStripMenuItem });
            ficheiroToolStripMenuItem.Font = new Font("Segoe UI", 14F);
            ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            ficheiroToolStripMenuItem.Size = new Size(112, 36);
            ficheiroToolStripMenuItem.Text = "Ficheiro";
            // 
            // atualizarToolStripMenuItem
            // 
            atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            atualizarToolStripMenuItem.Size = new Size(194, 36);
            atualizarToolStripMenuItem.Text = "Atualizar";
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Segoe UI", 14F);
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripSeparator1, btnAdicionar, btnAtualizar, btnRemover, btnLimpar });
            toolStrip1.Location = new Point(0, 40);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1262, 39);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.Fatcow_Farm_Fresh_Database_refresh_32;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(36, 36);
            toolStripButton1.Text = "Exibir dados";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 39);
            // 
            // btnAdicionar
            // 
            btnAdicionar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionar.Image = Properties.Resources.Fatcow_Farm_Fresh_User_add_32;
            btnAdicionar.ImageTransparentColor = Color.Magenta;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(36, 36);
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAtualizar.Image = Properties.Resources.Fatcow_Farm_Fresh_Upgrade_downgrade_account_32;
            btnAtualizar.ImageTransparentColor = Color.Magenta;
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(36, 36);
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnRemover
            // 
            btnRemover.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnRemover.Image = Properties.Resources.Fatcow_Farm_Fresh_List_suspended_accounts_32;
            btnRemover.ImageTransparentColor = Color.Magenta;
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(36, 36);
            btnRemover.Text = "Remover";
            btnRemover.Click += btnRemover_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnLimpar.Image = Properties.Resources.Fatcow_Farm_Fresh_Broom_32;
            btnLimpar.ImageTransparentColor = Color.Magenta;
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(36, 36);
            btnLimpar.Text = "Limpar";
            // 
            // dataGridViewSocios
            // 
            dataGridViewSocios.AllowUserToAddRows = false;
            dataGridViewSocios.AllowUserToDeleteRows = false;
            dataGridViewSocios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSocios.Location = new Point(0, 238);
            dataGridViewSocios.Name = "dataGridViewSocios";
            dataGridViewSocios.ReadOnly = true;
            dataGridViewSocios.RowHeadersVisible = false;
            dataGridViewSocios.RowHeadersWidth = 51;
            dataGridViewSocios.Size = new Size(1262, 695);
            dataGridViewSocios.TabIndex = 2;
            dataGridViewSocios.SelectionChanged += dataGridViewSocios_SelectionChanged;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dtpDataDeEntrada);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(txtNumero);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1262, 138);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registo:";
            // 
            // dtpDataDeEntrada
            // 
            dtpDataDeEntrada.Format = DateTimePickerFormat.Short;
            dtpDataDeEntrada.Location = new Point(231, 83);
            dtpDataDeEntrada.Name = "dtpDataDeEntrada";
            dtpDataDeEntrada.Size = new Size(163, 34);
            dtpDataDeEntrada.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(515, 81);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(569, 34);
            txtEmail.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(515, 33);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(569, 34);
            txtNome.TabIndex = 1;
            // 
            // txtNumero
            // 
            txtNumero.Enabled = false;
            txtNumero.Location = new Point(231, 35);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(125, 34);
            txtNumero.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 88);
            label4.Name = "label4";
            label4.Size = new Size(156, 28);
            label4.TabIndex = 0;
            label4.Text = "Data de Entrada:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(446, 87);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 0;
            label3.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(439, 41);
            label2.Name = "label2";
            label2.Size = new Size(70, 28);
            label2.TabIndex = 0;
            label2.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 41);
            label1.Name = "label1";
            label1.Size = new Size(169, 28);
            label1.TabIndex = 0;
            label1.Text = "Número de Sócio:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 933);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewSocios);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Listagem de Sócios";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSocios).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ficheiroToolStripMenuItem;
        private ToolStripMenuItem atualizarToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private DataGridView dataGridViewSocios;
        private GroupBox groupBox1;
        private DateTimePicker dtpDataDeEntrada;
        private TextBox txtEmail;
        private TextBox txtNome;
        private TextBox txtNumero;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnAdicionar;
        private ToolStripButton btnAtualizar;
        private ToolStripButton btnRemover;
        private ToolStripButton btnLimpar;
    }
}
