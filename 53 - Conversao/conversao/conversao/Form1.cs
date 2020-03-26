using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace conversao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            StreamWriter ficheiro = new StreamWriter(@"C:\dados.txt", false, Encoding.Default);
            //string
            ficheiro.WriteLine("esta frase é alfa numerica.");
            //int
            int valor = 150;
            ficheiro.WriteLine(valor);
            //boleano
            bool resultado = false;
            ficheiro.WriteLine(resultado);

            //data
            ficheiro.WriteLine(DateTime.Now);

            //COR
            Color cor = Color.FromArgb(30, 120, 58);
            ficheiro.WriteLine(cor.ToArgb());
            
            ficheiro.Dispose();
        }

        private void btn_ler_Click(object sender, EventArgs e)
        {
            StreamReader ficheiro = new StreamReader(@"C:\dados.txt");
            string a = ficheiro.ReadLine();
            //int
            int b = int.Parse(ficheiro.ReadLine());
            //boleano
            bool c = bool.Parse(ficheiro.ReadLine());
            //data
            DateTime d = DateTime.Parse(ficheiro.ReadLine());

            Color cor = Color.FromArgb(int.Parse(ficheiro.ReadLine()));
            pictureBox1.BackColor = cor;
            ficheiro.Dispose();
        }
    }
}
