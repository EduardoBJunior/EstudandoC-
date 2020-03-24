using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasseMetodos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            cl_matematica calculadora = new cl_matematica();

            int resultado = calculadora.Operacao(10, 5, "multiplicacao");
            caixa_texto.Text = resultado.ToString();


        }
    }
}
