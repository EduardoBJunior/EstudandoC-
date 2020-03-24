namespace Formularios
{
    partial class frmUm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_fechar = new System.Windows.Forms.Button();
            this.txt_resultadoFinal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_alterarLb2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(51, 245);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(75, 23);
            this.btn_fechar.TabIndex = 1;
            this.btn_fechar.TabStop = false;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // txt_resultadoFinal
            // 
            this.txt_resultadoFinal.AutoSize = true;
            this.txt_resultadoFinal.Location = new System.Drawing.Point(16, 9);
            this.txt_resultadoFinal.Name = "txt_resultadoFinal";
            this.txt_resultadoFinal.Size = new System.Drawing.Size(35, 13);
            this.txt_resultadoFinal.TabIndex = 2;
            this.txt_resultadoFinal.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // btn_alterarLb2
            // 
            this.btn_alterarLb2.Location = new System.Drawing.Point(51, 148);
            this.btn_alterarLb2.Name = "btn_alterarLb2";
            this.btn_alterarLb2.Size = new System.Drawing.Size(75, 23);
            this.btn_alterarLb2.TabIndex = 4;
            this.btn_alterarLb2.TabStop = false;
            this.btn_alterarLb2.Text = "Alterar LB 2";
            this.btn_alterarLb2.UseVisualStyleBackColor = true;
            this.btn_alterarLb2.Click += new System.EventHandler(this.btn_alterarLb2_Click);
            // 
            // frmUm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 297);
            this.Controls.Add(this.btn_alterarLb2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_resultadoFinal);
            this.Controls.Add(this.btn_fechar);
            this.Name = "frmUm";
            this.Text = "frmUm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Label txt_resultadoFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_alterarLb2;
    }
}