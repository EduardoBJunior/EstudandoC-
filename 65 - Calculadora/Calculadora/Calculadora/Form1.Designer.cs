namespace Calculadora
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
            this.txtb_operacao = new System.Windows.Forms.TextBox();
            this.lb_algoritimo = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtb_operacao
            // 
            this.txtb_operacao.Location = new System.Drawing.Point(15, 38);
            this.txtb_operacao.MaxLength = 30;
            this.txtb_operacao.Name = "txtb_operacao";
            this.txtb_operacao.Size = new System.Drawing.Size(190, 20);
            this.txtb_operacao.TabIndex = 0;
            this.txtb_operacao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtb_operacao_KeyDown);
            // 
            // lb_algoritimo
            // 
            this.lb_algoritimo.AutoSize = true;
            this.lb_algoritimo.Location = new System.Drawing.Point(12, 9);
            this.lb_algoritimo.Name = "lb_algoritimo";
            this.lb_algoritimo.Size = new System.Drawing.Size(109, 13);
            this.lb_algoritimo.TabIndex = 3;
            this.lb_algoritimo.Text = "Escreva o Algoritimo: ";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(49, 77);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 1;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(130, 77);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 2;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 132);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.lb_algoritimo);
            this.Controls.Add(this.txtb_operacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora vs1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb_operacao;
        private System.Windows.Forms.Label lb_algoritimo;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_sair;
    }
}

