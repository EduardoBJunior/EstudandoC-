using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace linq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            #region Lista de Nomes
            List<string> lista_nomes = new List<string>();
            lista_nomes.Add("João");
            lista_nomes.Add("Carlos");
            lista_nomes.Add("Miguel");
            lista_nomes.Add("Ana");
            lista_nomes.Add("Catarina");
            lista_nomes.Add("Pedro");
            lista_nomes.Add("Ricardo");
            lista_nomes.Add("Joaquim");
            lista_nomes.Add("Alexandre");
            lista_nomes.Add("Hilário");
            lista_nomes.Add("Jorge");
            lista_nomes.Add("Alberto");
            lista_nomes.Add("Hugo");
            lista_nomes.Add("Anabela");
            #endregion

            //utilizar LINQ

            //Exemplo usando  link para selecionar na lista apenas os registros com C
            //var lista_final = lista_nomes.Where(i => i.StartsWith("C"));

            // foreach (string item in lista_nomes)
            // {
            //     listBox1.Items.Add(item);
            // }
            //==========================================================================

            //var final = lista_nomes.Where(i => i.StartsWith("A"));

            //var final = from i in lista_nomes where i.StartsWith("A") select i;

            List<string> final = (from i in lista_nomes where i.StartsWith("A") select i).ToList<string>();

            listBox1.Items.Add(final[0]);

        }
    }
}
