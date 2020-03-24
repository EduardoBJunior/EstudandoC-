using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstantesEstruturas
{
    public partial class Form1 : Form
    {
        struct estrutura_pessoa
        {
            public string Nome;
            public string Apelido;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            normal objeto1 = new normal();
            Console.WriteLine(objeto1.Nome);

            Console.WriteLine(estatica.Nome);

            pessoa p1 = new pessoa();
            p1.Nome = "Eduardo";
            p1.Apelido = "Junior";

            estrutura_pessoa p2 = new estrutura_pessoa();
            p2.Nome = "Eduardo";
            p2.Apelido = "Junior";

            Console.WriteLine(p2.Nome + " "+p2.Apelido);

            estrutura_pessoa p3 = new estrutura_pessoa() {Nome = "Aline",Apelido ="Forstes" };
            Console.WriteLine(p3.Nome + " " + p3.Apelido);
        }
    }
}
