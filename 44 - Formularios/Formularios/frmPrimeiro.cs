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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_um_Click(object sender, EventArgs e)
        {
            geral.nome = textNome.Text;
            frmUm formulario1 = new frmUm();
            formulario1.ShowDialog();

        }

        private void btn_dois_Click(object sender, EventArgs e)
        {
            frmDois formulario1 = new frmDois();
            formulario1.ShowDialog();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
