
namespace TextoDecimal
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
            this.button1 = new System.Windows.Forms.Button();
            this.textDecimal2 = new TextoDecimal.TextDecimal();
            this.textDecimal1 = new TextoDecimal.TextDecimal();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textDecimal2
            // 
            this.textDecimal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDecimal2.Location = new System.Drawing.Point(57, 29);
            this.textDecimal2.Name = "textDecimal2";
            this.textDecimal2.NumeroCasasDecimais = 3;
            this.textDecimal2.PermitirDecimais = true;
            this.textDecimal2.SeparadorDecimal = TextoDecimal.TextDecimal.EnumSeparador.Virgula;
            this.textDecimal2.Size = new System.Drawing.Size(151, 35);
            this.textDecimal2.TabIndex = 1;
            this.textDecimal2.ValorMaximo = 100D;
            this.textDecimal2.ValorMinimo = -100D;
            this.textDecimal2.ValorPorPadrao = 0D;
            // 
            // textDecimal1
            // 
            this.textDecimal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDecimal1.Location = new System.Drawing.Point(57, 70);
            this.textDecimal1.Name = "textDecimal1";
            this.textDecimal1.NumeroCasasDecimais = 2;
            this.textDecimal1.PermitirDecimais = true;
            this.textDecimal1.SeparadorDecimal = TextoDecimal.TextDecimal.EnumSeparador.Virgula;
            this.textDecimal1.Size = new System.Drawing.Size(151, 35);
            this.textDecimal1.TabIndex = 0;
            this.textDecimal1.ValorMaximo = 100D;
            this.textDecimal1.ValorMinimo = -100D;
            this.textDecimal1.ValorPorPadrao = 0D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 214);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textDecimal2);
            this.Controls.Add(this.textDecimal1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextDecimal textDecimal1;
        private TextDecimal textDecimal2;
        private System.Windows.Forms.Button button1;
    }
}

