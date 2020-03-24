using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleCondicional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            int valor = 20;
            //switch (valor)
            //{
            //    case 10:
            //        label_resultado.Text = "primeira opção";
            //        break;
            //    case 20:
            //        label_resultado.Text = "segunda operação";
            //        break;

            //     default:
            //        label_resultado.Text = "Nenhum resultado.";
            //        break;
            //}

            //operador ternario

            label_resultado.Text = valor == 10 ? "SIM" : "NÂO";
            string resultadoFinal = valor == 10 ? "Sim Senhor" : "Nã Senhor";
        }
    }
}
