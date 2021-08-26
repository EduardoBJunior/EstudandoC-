
namespace ValoresNumericos
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
            this.label1_resultado = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.TextBox();
            this.btn_executar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1_resultado
            // 
            this.label1_resultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1_resultado.Location = new System.Drawing.Point(55, 47);
            this.label1_resultado.Name = "label1_resultado";
            this.label1_resultado.Size = new System.Drawing.Size(137, 62);
            this.label1_resultado.TabIndex = 0;
            this.label1_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(212, 50);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(100, 20);
            this.text1.TabIndex = 1;
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(212, 107);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(100, 20);
            this.text2.TabIndex = 2;
            // 
            // btn_executar
            // 
            this.btn_executar.Location = new System.Drawing.Point(212, 152);
            this.btn_executar.Name = "btn_executar";
            this.btn_executar.Size = new System.Drawing.Size(75, 23);
            this.btn_executar.TabIndex = 3;
            this.btn_executar.Text = " Executar";
            this.btn_executar.UseVisualStyleBackColor = true;
            this.btn_executar.Click += new System.EventHandler(this.btn_executar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 319);
            this.Controls.Add(this.btn_executar);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.label1_resultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_resultado;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.Button btn_executar;
    }
}

