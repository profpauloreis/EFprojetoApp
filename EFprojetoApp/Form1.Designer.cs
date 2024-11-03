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
            dataGridViewSocios = new DataGridView();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSocios).BeginInit();
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
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
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
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // dataGridViewSocios
            // 
            dataGridViewSocios.AllowUserToAddRows = false;
            dataGridViewSocios.AllowUserToDeleteRows = false;
            dataGridViewSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSocios.Dock = DockStyle.Fill;
            dataGridViewSocios.Location = new Point(0, 79);
            dataGridViewSocios.Name = "dataGridViewSocios";
            dataGridViewSocios.ReadOnly = true;
            dataGridViewSocios.RowHeadersWidth = 51;
            dataGridViewSocios.Size = new Size(1262, 594);
            dataGridViewSocios.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
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
    }
}
