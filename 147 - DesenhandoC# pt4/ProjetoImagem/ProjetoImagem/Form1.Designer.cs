﻿namespace ProjetoImagem
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
            this.pic_teste = new System.Windows.Forms.PictureBox();
            this.cmd_teste = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_teste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_teste)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_teste
            // 
            this.pic_teste.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pic_teste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_teste.ErrorImage = null;
            this.pic_teste.Location = new System.Drawing.Point(12, 12);
            this.pic_teste.Name = "pic_teste";
            this.pic_teste.Size = new System.Drawing.Size(634, 339);
            this.pic_teste.TabIndex = 0;
            this.pic_teste.TabStop = false;
            this.pic_teste.Click += new System.EventHandler(this.pic_teste_Click);
            // 
            // cmd_teste
            // 
            this.cmd_teste.BackColor = System.Drawing.Color.LightSalmon;
            this.cmd_teste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_teste.ErrorImage = null;
            this.cmd_teste.Location = new System.Drawing.Point(444, 368);
            this.cmd_teste.Name = "cmd_teste";
            this.cmd_teste.Size = new System.Drawing.Size(200, 42);
            this.cmd_teste.TabIndex = 4;
            this.cmd_teste.TabStop = false;
            this.cmd_teste.EnabledChanged += new System.EventHandler(this.cmd_teste_EnabledChanged);
            this.cmd_teste.Click += new System.EventHandler(this.cmd_teste_Click);
            this.cmd_teste.MouseEnter += new System.EventHandler(this.cmd_teste_MouseEnter);
            this.cmd_teste.MouseLeave += new System.EventHandler(this.cmd_teste_MouseLeave);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(667, 436);
            this.Controls.Add(this.cmd_teste);
            this.Controls.Add(this.pic_teste);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_teste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_teste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_teste;
        private System.Windows.Forms.PictureBox cmd_teste;
    }
}

