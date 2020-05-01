namespace AgendaSQL
{
    partial class frmResultado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResultado));
            this.btn_fechar = new System.Windows.Forms.Button();
            this.dgv_resultado = new System.Windows.Forms.DataGridView();
            this.lb_resultados = new System.Windows.Forms.Label();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_verRegistros = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(424, 299);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(75, 23);
            this.btn_fechar.TabIndex = 0;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // dgv_resultado
            // 
            this.dgv_resultado.AllowUserToAddRows = false;
            this.dgv_resultado.AllowUserToDeleteRows = false;
            this.dgv_resultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_resultado.Location = new System.Drawing.Point(12, 12);
            this.dgv_resultado.Margin = new System.Windows.Forms.Padding(0);
            this.dgv_resultado.MultiSelect = false;
            this.dgv_resultado.Name = "dgv_resultado";
            this.dgv_resultado.ReadOnly = true;
            this.dgv_resultado.RowHeadersVisible = false;
            this.dgv_resultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_resultado.Size = new System.Drawing.Size(487, 281);
            this.dgv_resultado.TabIndex = 1;
            this.dgv_resultado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_resultado_CellClick);
            this.dgv_resultado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_resultado_CellContentClick);
            // 
            // lb_resultados
            // 
            this.lb_resultados.AutoSize = true;
            this.lb_resultados.Location = new System.Drawing.Point(13, 299);
            this.lb_resultados.Name = "lb_resultados";
            this.lb_resultados.Size = new System.Drawing.Size(35, 13);
            this.lb_resultados.TabIndex = 2;
            this.lb_resultados.Text = "label1";
            // 
            // btn_apagar
            // 
            this.btn_apagar.Location = new System.Drawing.Point(343, 299);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(75, 23);
            this.btn_apagar.TabIndex = 3;
            this.btn_apagar.Text = "Apagar";
            this.btn_apagar.UseVisualStyleBackColor = true;
            this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(262, 299);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 4;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_verRegistros
            // 
            this.btn_verRegistros.Location = new System.Drawing.Point(181, 299);
            this.btn_verRegistros.Name = "btn_verRegistros";
            this.btn_verRegistros.Size = new System.Drawing.Size(75, 23);
            this.btn_verRegistros.TabIndex = 5;
            this.btn_verRegistros.Text = "Registros";
            this.btn_verRegistros.UseVisualStyleBackColor = true;
            this.btn_verRegistros.Click += new System.EventHandler(this.btn_verRegistros_Click);
            // 
            // frmResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 334);
            this.ControlBox = false;
            this.Controls.Add(this.btn_verRegistros);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_apagar);
            this.Controls.Add(this.lb_resultados);
            this.Controls.Add(this.dgv_resultado);
            this.Controls.Add(this.btn_fechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmResultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmResultado";
            this.Load += new System.EventHandler(this.frmResultado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.DataGridView dgv_resultado;
        private System.Windows.Forms.Label lb_resultados;
        private System.Windows.Forms.Button btn_apagar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_verRegistros;
    }
}