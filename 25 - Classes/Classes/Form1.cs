using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes
{
    public partial class Form1 : Form
    {
        string valor;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pessoa p1 = new pessoa();
            p1.nome = "Eduardo";
            p1.apelido = "Brandão";

            p1.IdentificarSe();
            
        }
    }
}
