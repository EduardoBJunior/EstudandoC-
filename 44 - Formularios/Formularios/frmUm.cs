using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmUm : Form
    {
        
        public frmUm()
        {
            InitializeComponent();
        
            txt_resultadoFinal.Text = geral.nome;
            
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_alterarLb2_Click(object sender, EventArgs e)
        {
            label2.Text = geral.nome;
        }
    }
}
