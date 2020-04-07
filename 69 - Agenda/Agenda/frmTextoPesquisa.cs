using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class frmTextoPesquisa : Form
    {

        //propriedade de Controle

            public bool cancelado { get; set; }
            public string texto { get; set; }

        public frmTextoPesquisa()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            //Cancelar o quadro 
            cancelado = true;
            this.Close();
        }

        private void btn_pesquisa_Click(object sender, EventArgs e)
        {
            if (txtBox_pesquisa.Text == string.Empty)
            {
                MessageBox.Show("Campo em branco digite o Contato que deseja pesquisar");
                return;
            }

                //define texto e fecha o quadro 
                texto = txtBox_pesquisa.Text;
            cancelado = false;
            this.Close();
        }
    }
}
