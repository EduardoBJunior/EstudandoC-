using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaSQL
{
    public partial class frmPesquisa : Form
    {
        public string texto_pesquisa { get; set; }
        public bool cancelado { get; set; }
        //=====================================================================
        public frmPesquisa()
        {
            InitializeComponent();
        }
        //=====================================================================
        private void frmPesquisa_Load(object sender, EventArgs e)
        {
            txtb_pesquisa.Focus();
        }
        //=====================================================================
        private void btn_pesquisa_Click(object sender, EventArgs e)
        {
            //executa a pesquisa., apenas se ecistir texto na txtb_pesquisa
            if (txtb_pesquisa.Text =="")
            {
                cancelado = true;
            }
            else
            {
                texto_pesquisa = txtb_pesquisa.Text;
            }

            
            this.Close();
        }
        //=====================================================================
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            //fecha o quadro cancelando a operação de pesquisa
            cancelado = true;
            this.Close();
        }
    }
}
