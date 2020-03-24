using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cl_calculo calculadora = new cl_calculo();

            int preco_inicial = Convert.ToInt16(textBox1.Text);

            int tipo_produto = 0;
            if (radioButton1.Checked)
            {
                tipo_produto = 1;
            }
            else if (radioButton2.Checked)
            {
                tipo_produto = 2;
            }
            else if (radioButton3.Checked)
            {
                tipo_produto = 3;
            }

            MessageBox.Show("preço final é = " + calculadora.CalcularPrecoFinal(preco_inicial, tipo_produto));

        }
    }
}
