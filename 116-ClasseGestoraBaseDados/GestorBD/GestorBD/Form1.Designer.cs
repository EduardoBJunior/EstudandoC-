namespace GestorBD
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
            this.button2 = new System.Windows.Forms.Button();
            this.txtb_pesquisa = new System.Windows.Forms.TextBox();
            this.bn_pesquisaSQLinject = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtb_nome = new System.Windows.Forms.TextBox();
            this.txtb_telefone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_4 = new System.Windows.Forms.Button();
            this.bt_inserirInt = new System.Windows.Forms.Button();
            this.btn_CompctBase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Criar Base de dados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 60);
            this.button2.TabIndex = 2;
            this.button2.Text = "Pesquisa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtb_pesquisa
            // 
            this.txtb_pesquisa.Location = new System.Drawing.Point(27, 98);
            this.txtb_pesquisa.Name = "txtb_pesquisa";
            this.txtb_pesquisa.Size = new System.Drawing.Size(200, 20);
            this.txtb_pesquisa.TabIndex = 1;
            // 
            // bn_pesquisaSQLinject
            // 
            this.bn_pesquisaSQLinject.Location = new System.Drawing.Point(182, 124);
            this.bn_pesquisaSQLinject.Name = "bn_pesquisaSQLinject";
            this.bn_pesquisaSQLinject.Size = new System.Drawing.Size(149, 60);
            this.bn_pesquisaSQLinject.TabIndex = 3;
            this.bn_pesquisaSQLinject.Text = "Pesquisa SQL Inject";
            this.bn_pesquisaSQLinject.UseVisualStyleBackColor = true;
            this.bn_pesquisaSQLinject.Click += new System.EventHandler(this.bn_pesquisaSQLinject_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(27, 242);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(149, 60);
            this.btn_insert.TabIndex = 4;
            this.btn_insert.Text = "Inset com VAriaveis BD";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(461, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 60);
            this.button3.TabIndex = 7;
            this.button3.Text = "Inset c campos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtb_nome
            // 
            this.txtb_nome.Location = new System.Drawing.Point(461, 14);
            this.txtb_nome.Name = "txtb_nome";
            this.txtb_nome.Size = new System.Drawing.Size(149, 20);
            this.txtb_nome.TabIndex = 5;
            // 
            // txtb_telefone
            // 
            this.txtb_telefone.Location = new System.Drawing.Point(461, 41);
            this.txtb_telefone.Name = "txtb_telefone";
            this.txtb_telefone.Size = new System.Drawing.Size(149, 20);
            this.txtb_telefone.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Telefone:";
            // 
            // bt_4
            // 
            this.bt_4.Location = new System.Drawing.Point(461, 153);
            this.bt_4.Name = "bt_4";
            this.bt_4.Size = new System.Drawing.Size(149, 60);
            this.bt_4.TabIndex = 10;
            this.bt_4.Text = "Ut de 2 metodos";
            this.bt_4.UseVisualStyleBackColor = true;
            this.bt_4.Click += new System.EventHandler(this.bt_4_Click);
            // 
            // bt_inserirInt
            // 
            this.bt_inserirInt.Location = new System.Drawing.Point(461, 242);
            this.bt_inserirInt.Name = "bt_inserirInt";
            this.bt_inserirInt.Size = new System.Drawing.Size(149, 60);
            this.bt_inserirInt.TabIndex = 11;
            this.bt_inserirInt.Text = "Inserir novos clientes";
            this.bt_inserirInt.UseVisualStyleBackColor = true;
            this.bt_inserirInt.Click += new System.EventHandler(this.bt_inserirInt_Click);
            // 
            // btn_CompctBase
            // 
            this.btn_CompctBase.Location = new System.Drawing.Point(461, 308);
            this.btn_CompctBase.Name = "btn_CompctBase";
            this.btn_CompctBase.Size = new System.Drawing.Size(149, 60);
            this.btn_CompctBase.TabIndex = 12;
            this.btn_CompctBase.Text = "Compactar a base de Dados";
            this.btn_CompctBase.UseVisualStyleBackColor = true;
            this.btn_CompctBase.Click += new System.EventHandler(this.btn_CompctBase_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 378);
            this.Controls.Add(this.btn_CompctBase);
            this.Controls.Add(this.bt_inserirInt);
            this.Controls.Add(this.bt_4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtb_telefone);
            this.Controls.Add(this.txtb_nome);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.bn_pesquisaSQLinject);
            this.Controls.Add(this.txtb_pesquisa);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtb_pesquisa;
        private System.Windows.Forms.Button bn_pesquisaSQLinject;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtb_nome;
        private System.Windows.Forms.TextBox txtb_telefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_4;
        private System.Windows.Forms.Button bt_inserirInt;
        private System.Windows.Forms.Button btn_CompctBase;
    }
}

