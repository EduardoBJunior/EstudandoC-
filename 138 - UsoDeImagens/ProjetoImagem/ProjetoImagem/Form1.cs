using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoImagem
{
    public partial class Form1 : Form
    {
        string pasta_imagens = "";
        Image imgFundo;

        //criar botão com imagens 
        Image img_normal;  // botão normal
        Image img_high;   //quando o mouse passa sobre o botão 
        Image img_disabled;// quando o botão esta inativo

        //=================================================================
        public Form1()
        {
            InitializeComponent();
            pasta_imagens = Application.StartupPath + @"\imagens\";

            //carregamento da imgem de fundo 
            imgFundo = Image.FromFile(pasta_imagens + "foto_1.jpg");

            //int largura = imgFundo.Width;
            //int altura = imgFundo.Height;

            //MessageBox.Show(string.Format("Largura: {0} | Altura: {1}",largura, altura));

            //SizeF dimencao = imgFundo.PhysicalDimension;

            //this.BackgroundImage = imgFundo;
            pic_teste.BackgroundImage = imgFundo;

            //cria um retangulo 
            Rectangle rect = pic_teste.Bounds;

            //mostra  os locais 
            //MessageBox.Show("posição X: " + rect.X.ToString() + " - " +
            //                "posição Y: " + rect.Y.ToString() + " - " +
            //                "Largura: " + rect.Width.ToString() + " - " +
            //                "Altura: " + rect.Height.ToString());

            img_normal = Image.FromFile(pasta_imagens + "btn_normal.png");
            img_high = Image.FromFile(pasta_imagens + "btn_high.png");
            img_disabled = Image.FromFile(pasta_imagens + "btn_disabled.png");


        }
        //=================================================================
        private void Form1_Load(object sender, EventArgs e)
        {
            //int X = pic_teste.Location.X;
            //int Y = pic_teste.Location.Y;

            //MessageBox.Show(X.ToString() +" - " + Y.ToString());

            //botão
            cmd_teste.BackgroundImage = img_normal;
        }
        //===============================================================
        private void button1_Click(object sender, EventArgs e)
        {
            //muda ao clicar no botão
            //pic_teste.Location = new Point(295, 12);
            
            
            //bounds = frontreira
            Rectangle r_pic = pic_teste.Bounds;
            Rectangle r__but = button2.Bounds;

            //reposiciona o botão 2
            //button2.Location = new Point(r_pic.X, r_pic.Y);

            //button2.Location = new Point(r_pic.X, r_pic.Bottom);

            button2.Location = new Point(r_pic.X + r_pic.Width / 2 - r__but.Width / 2,                                r_pic.Y + r_pic.Height/2 - r__but.Height/2);
        }
        //===============================================================
        private void pic_teste_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Picture Box Clicada!");
        }
        //===============================================================
        private void button2_Click(object sender, EventArgs e)
        {

        }
        //===============================================================
        private void cmd_teste_MouseEnter(object sender, EventArgs e)
        {
            //altera imagem para high
            cmd_teste.BackgroundImage = img_high;
        }

        private void cmd_teste_MouseLeave(object sender, EventArgs e)
        {
            //retorna ao aspecnto normal quando o mouse sair 
            cmd_teste.BackgroundImage = img_normal;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cmd_teste.Enabled)
            {
                cmd_teste.Enabled = false;
                
            }
            else
            {
                cmd_teste.Enabled = true;
            }
        }

        private void cmd_teste_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botão Clicado");
        }

        private void cmd_teste_EnabledChanged(object sender, EventArgs e)
        {
            //define a imagem ativa ou inativa do botão personalizado
            if (cmd_teste.Enabled)
            {
                cmd_teste.BackgroundImage = img_normal;
            }
            else
            {
                cmd_teste.BackgroundImage = img_disabled;
            }
        }
    }
}
