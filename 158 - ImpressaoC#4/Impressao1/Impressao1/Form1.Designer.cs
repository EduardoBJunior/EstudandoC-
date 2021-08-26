
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
            this.lista = new System.Windows.Forms.ListView();
            this.CaixaSetup = new System.Windows.Forms.PrintDialog();
            this.visualizar = new System.Windows.Forms.PrintPreviewControl();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.caixa_visualizacao = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(465, 514);
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
            // lista
            // 
            this.lista.HideSelection = false;
            this.lista.Location = new System.Drawing.Point(440, 11);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(150, 134);
            this.lista.TabIndex = 1;
            this.lista.UseCompatibleStateImageBehavior = false;
            // 
            // CaixaSetup
            // 
            this.CaixaSetup.UseEXDialog = true;
            // 
            // visualizar
            // 
            this.visualizar.Location = new System.Drawing.Point(13, 13);
            this.visualizar.Name = "visualizar";
            this.visualizar.Size = new System.Drawing.Size(408, 558);
            this.visualizar.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(440, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Pagina seguinte";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(440, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Pagina Anterior";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.ClientSize = new System.Drawing.Size(605, 583);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.visualizar);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument documento;
        private System.Windows.Forms.ListView lista;
        private System.Windows.Forms.PrintDialog CaixaSetup;
        private System.Windows.Forms.PrintPreviewControl visualizar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PrintPreviewDialog caixa_visualizacao;
    }
}

