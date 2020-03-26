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

namespace CaixaDialogo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Message Box");
            //Mensagem, titulo, botao e icone
            //MessageBox.Show("Texto da Mensagem", 
            //                 "Aviso",
            //                 MessageBoxButtons.OK,
            //                 MessageBoxIcon.Information);

            //caixa de Dialogo com Resultado
            if (MessageBox.Show("Deseja sair da Aplicacao", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            
            //fecha a aplicação
            Application.Exit();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog telacaixa = new OpenFileDialog();
            telacaixa.Title = "Escolher ficheiro";
            telacaixa.InitialDirectory = @"C:\";
            telacaixa.Filter = "JPRG Images(*.jpg)|*.jpg| BMP Files(*.bmp)|*.bmp";
            telacaixa.Filter = "JPRG Images(*.jpg)|*.jpg| BMP Files(*.bmp)|*.bmp";
            

            if (telacaixa.ShowDialog() == DialogResult.Cancel ) return;

            //MessageBox.Show("O utilizador escolheu o ficheiro "+telacaixa.FileName);
            pictureBox1.BackgroundImage = Image.FromFile(telacaixa.FileName);
            telacaixa.Dispose();
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog caixa = new SaveFileDialog();
            caixa.Title = "Gravar Ficheiro";
            caixa.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            caixa.Filter = "TXT files (*.txt)|*.txt";
            if (caixa.ShowDialog() == DialogResult.Cancel) return;

            //grava o ficheiro
            string ficheiro = caixa.FileName;

            StreamWriter file = new StreamWriter(ficheiro, false, Encoding.Default);
            file.WriteLine("TEXT");
            file.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog caixa = new FolderBrowserDialog();
            caixa.SelectedPath = @"C:\";
            if (caixa.ShowDialog() == DialogResult.Cancel) return;

            ////retorna a pasta escolhida
            MessageBox.Show("A pasta excluida foi "+ caixa.SelectedPath);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ColorDialog caixa = new ColorDialog();
            caixa.Color = pictureBox1.BackColor;

            if (caixa.ShowDialog() == DialogResult.Cancel) return;

            pictureBox1.BackColor = caixa.Color;
        }
    }
}
