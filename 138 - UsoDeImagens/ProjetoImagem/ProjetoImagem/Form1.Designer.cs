namespace ProjetoImagem
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cmd_teste = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_teste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_teste)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_teste
            // 
            this.pic_teste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_teste.ErrorImage = null;
            this.pic_teste.Location = new System.Drawing.Point(44, 101);
            this.pic_teste.Name = "pic_teste";
            this.pic_teste.Size = new System.Drawing.Size(300, 198);
            this.pic_teste.TabIndex = 0;
            this.pic_teste.TabStop = false;
            this.pic_teste.Click += new System.EventHandler(this.pic_teste_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(470, 324);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(3);
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Teste";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(470, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(429, 256);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 33);
            this.button3.TabIndex = 3;
            this.button3.Text = "Ativa/Desativa botão perso.";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmd_teste
            // 
            this.cmd_teste.BackColor = System.Drawing.Color.Transparent;
            this.cmd_teste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_teste.ErrorImage = null;
            this.cmd_teste.Location = new System.Drawing.Point(12, 12);
            this.cmd_teste.Name = "cmd_teste";
            this.cmd_teste.Size = new System.Drawing.Size(155, 39);
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
            this.ClientSize = new System.Drawing.Size(622, 363);
            this.Controls.Add(this.cmd_teste);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox cmd_teste;
    }
}

