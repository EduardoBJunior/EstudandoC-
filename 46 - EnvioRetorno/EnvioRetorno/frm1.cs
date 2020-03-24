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
    public partial class frm1 : Form
    {
        string nome= null;
        public frm1()
        {
            InitializeComponent();
            
        }

        private void btn_avancar_Click(object sender, EventArgs e)
        {
            if (Lb_texto.Text !="")
            {
                nome = Lb_texto.Text;
            }
            frm2 tela2 = new frm2(nome);
            tela2.ShowDialog();

            if (tela2.nome !=null)
            {
                Lb_texto.Text = tela2.nome;
            }

        }
    }
}
