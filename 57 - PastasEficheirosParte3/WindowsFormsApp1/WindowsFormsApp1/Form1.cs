using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Copia um ficheiro e manda para a pasta do segundo comando 
            //File.Copy(@"C:\dados.txt", @"C:\temps\dados.txt");
            //Move um arquivo de uma pasta para a outra
            //File.Move(@"C:\dados.txt", @"C:\temps\dados.txt");

            string[] lista_ficheiros = Directory.GetFiles(@"C:\", "*.txt");

            foreach(string item in lista_ficheiros)
            {
                listBox1.Items.Add(item);
                File.Move(item, @"C:\temps\"+Path.GetFileName(item));
            }

            MessageBox.Show("Terminado");
            //listBox1.Items.Clear();
        }
    }
}
