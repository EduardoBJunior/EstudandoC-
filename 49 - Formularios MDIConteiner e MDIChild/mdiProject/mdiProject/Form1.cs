using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdiProject
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmUm f = new frmUm(this);
            f.Show();
        }
        //para transformar um formulario como fomulario principal tem que ativar o evento "isMdiConteiner"
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUm f = new frmUm(this);
            //informa que a tela  um é filha da frmmain , não é muito usado 
            //f.MdiParent = this;
            f.Show();
        }
    }
}
