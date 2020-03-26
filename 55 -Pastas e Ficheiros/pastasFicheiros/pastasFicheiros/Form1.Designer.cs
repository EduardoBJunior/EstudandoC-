namespace pastasFicheiros
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtb_nome = new System.Windows.Forms.TextBox();
            this.data_hora = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gravar Configurações";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtb_nome
            // 
            this.txtb_nome.Location = new System.Drawing.Point(12, 21);
            this.txtb_nome.Name = "txtb_nome";
            this.txtb_nome.Size = new System.Drawing.Size(163, 20);
            this.txtb_nome.TabIndex = 1;
            // 
            // data_hora
            // 
            this.data_hora.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_hora.Location = new System.Drawing.Point(12, 47);
            this.data_hora.Name = "data_hora";
            this.data_hora.Size = new System.Drawing.Size(163, 20);
            this.data_hora.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(183, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Carregar as  Configurações";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 246);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.data_hora);
            this.Controls.Add(this.txtb_nome);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtb_nome;
        private System.Windows.Forms.DateTimePicker data_hora;
        private System.Windows.Forms.Button button2;
    }
}

