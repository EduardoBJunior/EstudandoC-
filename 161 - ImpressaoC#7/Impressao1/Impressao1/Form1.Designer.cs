
namespace Impressao1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.documento = new System.Drawing.Printing.PrintDocument();
            this.CaixaSetup = new System.Windows.Forms.PrintDialog();
            this.caixa_visualizacao = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // documento
            // 
            this.documento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.documento_PrintPage);
            // 
            // CaixaSetup
            // 
            this.CaixaSetup.UseEXDialog = true;
            // 
            // caixa_visualizacao
            // 
            this.caixa_visualizacao.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.caixa_visualizacao.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.caixa_visualizacao.ClientSize = new System.Drawing.Size(400, 300);
            this.caixa_visualizacao.Enabled = true;
            this.caixa_visualizacao.Icon = ((System.Drawing.Icon)(resources.GetObject("caixa_visualizacao.Icon")));
            this.caixa_visualizacao.Name = "printPreviewDialog1";
            this.caixa_visualizacao.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 200);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument documento;
        private System.Windows.Forms.PrintDialog CaixaSetup;
        private System.Windows.Forms.PrintPreviewDialog caixa_visualizacao;
    }
}

