namespace ClasseMetodos
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
            this.caixa_texto = new System.Windows.Forms.Label();
            this.btn_executar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // caixa_texto
            // 
            this.caixa_texto.AutoSize = true;
            this.caixa_texto.Location = new System.Drawing.Point(37, 29);
            this.caixa_texto.Name = "caixa_texto";
            this.caixa_texto.Size = new System.Drawing.Size(35, 13);
            this.caixa_texto.TabIndex = 0;
            this.caixa_texto.Text = "label1";
            // 
            // btn_executar
            // 
            this.btn_executar.Location = new System.Drawing.Point(253, 144);
            this.btn_executar.Name = "btn_executar";
            this.btn_executar.Size = new System.Drawing.Size(75, 23);
            this.btn_executar.TabIndex = 1;
            this.btn_executar.Text = "button1";
            this.btn_executar.UseVisualStyleBackColor = true;
            this.btn_executar.Click += new System.EventHandler(this.btn_executar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 223);
            this.Controls.Add(this.btn_executar);
            this.Controls.Add(this.caixa_texto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label caixa_texto;
        private System.Windows.Forms.Button btn_executar;
    }
}

