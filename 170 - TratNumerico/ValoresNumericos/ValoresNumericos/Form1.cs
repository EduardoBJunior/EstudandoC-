using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValoresNumericos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            #region 170
            //int p1 = 0;
            //int p2 = 0;


            //int.TryParse(text1.Text, out p1);
            //int.TryParse(text2.Text, out p2);


            //int resultado = p1 + p2;

            //label1_resultado.Text = resultado.ToString();
            #endregion


            #region 171

            //double valor1 = 1.546;
            //double valor2 = 1.3;
            ////double resultado = valor1 + valor2;
            //double resultado = Math.Round(valor1 + valor2);
            // label1_resultado.Text = resultado.ToString("0.00");

            //double resultado2 = double.Parse(label1_resultado.Text);
            //int v = 0;

            #endregion


            #region 172

            //string valor_str = "123";

            //int valor = int.Parse(valor_str);

            //int valot = Convert.ToInt32(valor_str);

            //DateTime data = Convert.ToDateTime(DateTime.Now);

            //bool valorbool = true;

            //short v = 1; //true para ser felse é sempre zero

            //bool valorBol = Convert.ToBoolean(v);

            //label1_resultado.Text = valorBol.ToString();

            /*
             5opções setup
             - apresentar data
             - apresentar hora 
             - apresentar dat de nascimento
             
            true
            false
            false 
            true

            010110


             */

            string confifg = "010110";

            bool opcao1 = Convert.ToBoolean(confifg[0]);
            bool opcao2 = Convert.ToBoolean(confifg[1]);
            bool opcao3 = Convert.ToBoolean(confifg[2]);
            bool opcao4 = Convert.ToBoolean(confifg[3]);
            bool opcao5 = Convert.ToBoolean(confifg[4]);

            label1_resultado.Text = opcao1.ToString();

            #endregion

        }
    }
}
