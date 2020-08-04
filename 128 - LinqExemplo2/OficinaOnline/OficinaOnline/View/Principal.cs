using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OficinaOnline
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.Frm_CadastroCliente cadastro = new View.Frm_CadastroCliente();
            cadastro.ShowDialog();
        }
    }
}
