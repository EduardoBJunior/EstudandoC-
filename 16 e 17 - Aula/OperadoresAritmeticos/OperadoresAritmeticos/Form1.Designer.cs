namespace OperadoresAritmeticos
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
            this.label_resultado = new System.Windows.Forms.Label();
            this.btn_ecxecutar = new System.Windows.Forms.Button();
            this.text_parcela_1 = new System.Windows.Forms.TextBox();
            this.text_parcela_2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_resultado
            // 
            this.label_resultado.AutoSize = true;
            this.label_resultado.Location = new System.Drawing.Point(45, 90);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(35, 13);
            this.label_resultado.TabIndex = 0;
            this.label_resultado.Text = "label1";
            // 
            // btn_ecxecutar
            // 
            this.btn_ecxecutar.Location = new System.Drawing.Point(38, 124);
            this.btn_ecxecutar.Name = "btn_ecxecutar";
            this.btn_ecxecutar.Size = new System.Drawing.Size(75, 23);
            this.btn_ecxecutar.TabIndex = 1;
            this.btn_ecxecutar.Text = "Executar";
            this.btn_ecxecutar.UseVisualStyleBackColor = true;
            this.btn_ecxecutar.Click += new System.EventHandler(this.btn_ecxecutar_Click);
            // 
            // text_parcela_1
            // 
            this.text_parcela_1.Location = new System.Drawing.Point(38, 22);
            this.text_parcela_1.Name = "text_parcela_1";
            this.text_parcela_1.Size = new System.Drawing.Size(100, 20);
            this.text_parcela_1.TabIndex = 2;
            // 
            // text_parcela_2
            // 
            this.text_parcela_2.Location = new System.Drawing.Point(38, 48);
            this.text_parcela_2.Name = "text_parcela_2";
            this.text_parcela_2.Size = new System.Drawing.Size(100, 20);
            this.text_parcela_2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 450);
            this.Controls.Add(this.text_parcela_2);
            this.Controls.Add(this.text_parcela_1);
            this.Controls.Add(this.btn_ecxecutar);
            this.Controls.Add(this.label_resultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_resultado;
        private System.Windows.Forms.Button btn_ecxecutar;
        private System.Windows.Forms.TextBox text_parcela_1;
        private System.Windows.Forms.TextBox text_parcela_2;
    }
}

