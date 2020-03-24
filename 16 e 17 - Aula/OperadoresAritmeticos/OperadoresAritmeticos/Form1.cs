using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperadoresAritmeticos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ecxecutar_Click(object sender, EventArgs e)
        {
            //int parcela_1 = int.Parse(text_parcela_1.Text);
            //int parcela_2 = int.Parse(text_parcela_2.Text);
            ////adição
            //int resultado = parcela_1 + parcela_2;
            ////subitração
            //resultado = parcela_1 - parcela_2;
            ////label_resultado.Text = Convert.ToString(resultado);


            //// multiplicação
            ////resultado = parcela_1 * parcela_2;

            ////Divisão
            ////resultado = parcela_1 / parcela_2;

            ////Sobra da divis~~ao - chamdo de Modulo (%)
            //resultado = parcela_1 % parcela_2;

            int resultado = 0;
            //resultado += 5;
            //Prefixo ou sufixo na apresentação o prefixo vem na fetrente

            label_resultado.Text = resultado.ToString();

        }
    }
}
