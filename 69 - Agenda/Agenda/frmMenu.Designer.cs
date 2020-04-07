namespace Agenda
{
    partial class frmMenu
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
            this.bnt_inserir_editar = new System.Windows.Forms.Button();
            this.bnt_pesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bnt_inserir_editar
            // 
            this.bnt_inserir_editar.Location = new System.Drawing.Point(35, 75);
            this.bnt_inserir_editar.Name = "bnt_inserir_editar";
            this.bnt_inserir_editar.Size = new System.Drawing.Size(165, 32);
            this.bnt_inserir_editar.TabIndex = 0;
            this.bnt_inserir_editar.Text = "Inserir/Editar";
            this.bnt_inserir_editar.UseVisualStyleBackColor = true;
            this.bnt_inserir_editar.Click += new System.EventHandler(this.bnt_inserir_editar_Click);
            // 
            // bnt_pesquisar
            // 
            this.bnt_pesquisar.Location = new System.Drawing.Point(35, 113);
            this.bnt_pesquisar.Name = "bnt_pesquisar";
            this.bnt_pesquisar.Size = new System.Drawing.Size(165, 32);
            this.bnt_pesquisar.TabIndex = 1;
            this.bnt_pesquisar.Text = "Pesquisar";
            this.bnt_pesquisar.UseVisualStyleBackColor = true;
            this.bnt_pesquisar.Click += new System.EventHandler(this.bnt_pesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Agenda";
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(35, 151);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(165, 32);
            this.btn_sair.TabIndex = 3;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click_1);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 207);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bnt_pesquisar);
            this.Controls.Add(this.bnt_inserir_editar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnt_inserir_editar;
        private System.Windows.Forms.Button bnt_pesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sair;
    }
}

