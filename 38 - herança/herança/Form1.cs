using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace herança
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            cl_carro carro = new cl_carro();

            cl_bicicleta bicicleta = new cl_bicicleta();

            carro.Acelerar();
            bicicleta.Acelerar();

            carro.Parar();
            bicicleta.Parar();
          
        }
    }
}
