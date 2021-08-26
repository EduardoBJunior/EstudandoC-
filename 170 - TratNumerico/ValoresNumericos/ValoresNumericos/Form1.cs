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

            double valor = 1.5;

             label1_resultado.Text = valor.ToString();

            #endregion  

        }
    }
}
