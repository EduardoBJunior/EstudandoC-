namespace EnvioRetorno
{
    partial class frm1
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
            this.btn_avancar = new System.Windows.Forms.Button();
            this.Lb_texto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_avancar
            // 
            this.btn_avancar.Location = new System.Drawing.Point(293, 207);
            this.btn_avancar.Name = "btn_avancar";
            this.btn_avancar.Size = new System.Drawing.Size(75, 23);
            this.btn_avancar.TabIndex = 0;
            this.btn_avancar.Text = "Avançar";
            this.btn_avancar.UseVisualStyleBackColor = true;
            this.btn_avancar.Click += new System.EventHandler(this.btn_avancar_Click);
            // 
            // Lb_texto
            // 
            this.Lb_texto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lb_texto.Location = new System.Drawing.Point(8, 8);
            this.Lb_texto.Name = "Lb_texto";
            this.Lb_texto.Size = new System.Drawing.Size(360, 55);
            this.Lb_texto.TabIndex = 1;
            this.Lb_texto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 242);
            this.Controls.Add(this.Lb_texto);
            this.Controls.Add(this.btn_avancar);
            this.Name = "frm1";
            this.Text = "FRM_1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_avancar;
        private System.Windows.Forms.Label Lb_texto;
    }
}

