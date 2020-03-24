namespace Enumerador
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
            this.btn_direita = new System.Windows.Forms.Button();
            this.btn_baixo = new System.Windows.Forms.Button();
            this.btn_cima = new System.Windows.Forms.Button();
            this.btn_esquerda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_direita
            // 
            this.btn_direita.Location = new System.Drawing.Point(125, 122);
            this.btn_direita.Name = "btn_direita";
            this.btn_direita.Size = new System.Drawing.Size(75, 23);
            this.btn_direita.TabIndex = 0;
            this.btn_direita.Text = "Direita";
            this.btn_direita.UseVisualStyleBackColor = true;
            this.btn_direita.Click += new System.EventHandler(this.btn_direita_Click);
            // 
            // btn_baixo
            // 
            this.btn_baixo.Location = new System.Drawing.Point(74, 151);
            this.btn_baixo.Name = "btn_baixo";
            this.btn_baixo.Size = new System.Drawing.Size(65, 23);
            this.btn_baixo.TabIndex = 0;
            this.btn_baixo.Text = "Baixo";
            this.btn_baixo.UseVisualStyleBackColor = true;
            this.btn_baixo.Click += new System.EventHandler(this.btn_baixo_Click);
            // 
            // btn_cima
            // 
            this.btn_cima.Location = new System.Drawing.Point(74, 93);
            this.btn_cima.Name = "btn_cima";
            this.btn_cima.Size = new System.Drawing.Size(65, 23);
            this.btn_cima.TabIndex = 0;
            this.btn_cima.Text = "Cima";
            this.btn_cima.UseVisualStyleBackColor = true;
            this.btn_cima.Click += new System.EventHandler(this.btn_cima_Click);
            // 
            // btn_esquerda
            // 
            this.btn_esquerda.Location = new System.Drawing.Point(13, 122);
            this.btn_esquerda.Name = "btn_esquerda";
            this.btn_esquerda.Size = new System.Drawing.Size(65, 23);
            this.btn_esquerda.TabIndex = 0;
            this.btn_esquerda.Text = "Esquerda";
            this.btn_esquerda.UseVisualStyleBackColor = true;
            this.btn_esquerda.Click += new System.EventHandler(this.btn_esquerda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 186);
            this.Controls.Add(this.btn_esquerda);
            this.Controls.Add(this.btn_cima);
            this.Controls.Add(this.btn_baixo);
            this.Controls.Add(this.btn_direita);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_direita;
        private System.Windows.Forms.Button btn_baixo;
        private System.Windows.Forms.Button btn_cima;
        private System.Windows.Forms.Button btn_esquerda;
    }
}

