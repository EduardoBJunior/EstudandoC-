
namespace EviarEmail
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
            this.btnEviar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.btn_verificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEviar
            // 
            this.btnEviar.Location = new System.Drawing.Point(126, 160);
            this.btnEviar.Name = "btnEviar";
            this.btnEviar.Size = new System.Drawing.Size(270, 111);
            this.btnEviar.TabIndex = 0;
            this.btnEviar.Text = "Eviar";
            this.btnEviar.UseVisualStyleBackColor = true;
            this.btnEviar.Click += new System.EventHandler(this.btnEviar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Endereço de Email: ";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(126, 77);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(270, 20);
            this.txt_email.TabIndex = 2;
            // 
            // btn_verificar
            // 
            this.btn_verificar.Location = new System.Drawing.Point(126, 103);
            this.btn_verificar.Name = "btn_verificar";
            this.btn_verificar.Size = new System.Drawing.Size(270, 30);
            this.btn_verificar.TabIndex = 3;
            this.btn_verificar.Text = "Verifica Email";
            this.btn_verificar.UseVisualStyleBackColor = true;
            this.btn_verificar.Click += new System.EventHandler(this.btn_verificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 342);
            this.Controls.Add(this.btn_verificar);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEviar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEviar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button btn_verificar;
    }
}

