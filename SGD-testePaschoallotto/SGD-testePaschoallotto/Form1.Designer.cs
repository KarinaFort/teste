
namespace SGD_testePaschoallotto
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarUmArquivoCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVerSalvos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivosToolStripMenuItem
            // 
            this.arquivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarUmArquivoCSVToolStripMenuItem,
            this.exportarDadosToolStripMenuItem});
            this.arquivosToolStripMenuItem.Name = "arquivosToolStripMenuItem";
            this.arquivosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.arquivosToolStripMenuItem.Text = "Arquivos";
            // 
            // importarUmArquivoCSVToolStripMenuItem
            // 
            this.importarUmArquivoCSVToolStripMenuItem.Name = "importarUmArquivoCSVToolStripMenuItem";
            this.importarUmArquivoCSVToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.importarUmArquivoCSVToolStripMenuItem.Text = "Importar um arquivo";
            this.importarUmArquivoCSVToolStripMenuItem.Click += new System.EventHandler(this.importarUmArquivoCSVToolStripMenuItem_Click);
            // 
            // exportarDadosToolStripMenuItem
            // 
            this.exportarDadosToolStripMenuItem.Name = "exportarDadosToolStripMenuItem";
            this.exportarDadosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.exportarDadosToolStripMenuItem.Text = "Exportar dados ";
            this.exportarDadosToolStripMenuItem.Click += new System.EventHandler(this.exportarDadosToolStripMenuItem_Click);
            // 
            // btnVerSalvos
            // 
            this.btnVerSalvos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerSalvos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnVerSalvos.Location = new System.Drawing.Point(321, 287);
            this.btnVerSalvos.Name = "btnVerSalvos";
            this.btnVerSalvos.Size = new System.Drawing.Size(175, 29);
            this.btnVerSalvos.TabIndex = 3;
            this.btnVerSalvos.Text = "Visualizar salvos";
            this.btnVerSalvos.UseVisualStyleBackColor = true;
            this.btnVerSalvos.Click += new System.EventHandler(this.btnVerSalvos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(326, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Importar arquivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(327, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Exportar arquivo";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SGD_testePaschoallotto.Properties.Resources.icons8_export_48px;
            this.pictureBox2.Location = new System.Drawing.Point(281, 98);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SGD_testePaschoallotto.Properties.Resources.icons8_import_48px;
            this.pictureBox1.Location = new System.Drawing.Point(281, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerSalvos);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Gerenciamentro de dados";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarUmArquivoCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarDadosToolStripMenuItem;
        private System.Windows.Forms.Button btnVerSalvos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

