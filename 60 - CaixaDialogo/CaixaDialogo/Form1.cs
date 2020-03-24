using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (MessageBox.Show("Deseja sair da Aplicacao", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            Application.Exit();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog telacaixa = new OpenFileDialog();
            telacaixa.Title = "Escolher ficheiro";
            telacaixa.InitialDirectory = @"C:\";
            telacaixa.Filter = "JPRG Images(*.jpg)|*.jpg| BMP Files(*.bmp)|*.bmp";

            if (telacaixa.ShowDialog() == DialogResult.Cancel ) return;

            //MessageBox.Show("O utilizador escolheu o ficheiro "+telacaixa.FileName);
            pictureBox1.BackgroundImage = Image.FromFile(telacaixa.FileName);
            telacaixa.Dispose();
            
            
        }
    }
}
