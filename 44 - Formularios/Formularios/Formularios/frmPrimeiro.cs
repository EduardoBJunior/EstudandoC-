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
            frmUm formulario1 = new frmUm();
            formulario1.ShowDialog();

        }
    }
}
