using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnvioRetorno
{
    public partial class frm2 : Form
    {
        public string nome { get; set; }
        public frm2(string nome)
        {
            InitializeComponent();
            this.nome= nome;
            txtb_nome.Text = nome;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (txtb_nome.Text == "") { 
                nome = null;
                MessageBox.Show("O campo nome esta em branco, digite novamente");
            }
            else { 
            nome = txtb_nome.Text;
            this.Close();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            nome = null;
            this.Close();
        }
    }
}
