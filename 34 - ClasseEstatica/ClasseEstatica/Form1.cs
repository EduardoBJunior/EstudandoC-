using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasseEstatica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = estatica.NomePrograma; 
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            normal objeto1 = new normal();
            objeto1.Nome = "Eduardo";
            objeto1.ApresentarNome();

            normal objeto2 = new normal();
            objeto2.Nome = "Aline";
            objeto2.ApresentarNome();

            estatica.Nome = "Brandão";
            estatica.ApresentarNome();

            estatica.Nome = "Junior";
            estatica.ApresentarNome(); 
              
        }
    }
}
