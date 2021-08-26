
namespace ProjetoImagem2
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
            this.separadorHorizontal1 = new ProjetoImagem2.SeparadorHorizontal();
            this.SuspendLayout();
            // 
            // separadorHorizontal1
            // 
            this.separadorHorizontal1.AlphaClaro = ((byte)(200));
            this.separadorHorizontal1.AlphaEscuro = ((byte)(100));
            this.separadorHorizontal1.BackColor = System.Drawing.Color.Transparent;
            this.separadorHorizontal1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("separadorHorizontal1.BackgroundImage")));
            this.separadorHorizontal1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.separadorHorizontal1.CorClara = System.Drawing.Color.White;
            this.separadorHorizontal1.CorEscura = System.Drawing.Color.Black;
            this.separadorHorizontal1.Location = new System.Drawing.Point(28, 113);
            this.separadorHorizontal1.Name = "separadorHorizontal1";
            this.separadorHorizontal1.Size = new System.Drawing.Size(545, 4);
            this.separadorHorizontal1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(641, 457);
            this.Controls.Add(this.separadorHorizontal1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private SeparadorHorizontal separadorHorizontal1;
    }
}

