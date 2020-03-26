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

namespace FicheirosTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //gravar um valor;
            int valor = 100;
            // Criar um arquivo, onde o valor Boleano "False" faz com que substitua o arquivo por outro caso o memso ja exista e o True adiciona o os valores ao Ficheiro  caso ja exista
            StreamWriter ficheiro = new StreamWriter(@"C:\file.txt",true,Encoding.Default);

            // WriteLine grava na linha pulando de linha em linha ja o Write grava na mesma slinha
            ficheiro.WriteLine("Primeira Frase.");
            ficheiro.WriteLine("Segunda Frase.");
            ficheiro.WriteLine("Usando uma VAriavel "+valor);
            ficheiro.WriteLine("Digitando o Valor " + 1000);
            ficheiro.WriteLine("Adicionando uma nova Frase");
            ficheiro.WriteLine(textBox1.Text);

            //Fecha o Ficheiro, usa o dispose = alem de fechar limpa os recursos da memoria;
            ficheiro.Dispose();

            textBox1.Text = "";
            textBox1.Focus();           //StreamWriter ficheiro = new StreamWriter("C:\\file.txt");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader ficheiro = new StreamReader(@"C:\file.txt",Encoding.Default);
            //listBox1.Items.Add(ficheiro.ReadLine());
            while (!ficheiro.EndOfStream)
            {
                listb.Items.Add(ficheiro.ReadLine());
            }
            ficheiro.Dispose();
        }
    }
}
