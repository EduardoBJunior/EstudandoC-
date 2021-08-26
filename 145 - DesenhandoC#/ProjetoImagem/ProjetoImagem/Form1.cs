using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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


            img_normal = Image.FromFile(pasta_imagens + "btn_normal.png");
            img_high = Image.FromFile(pasta_imagens + "btn_high.png");
            img_disabled = Image.FromFile(pasta_imagens + "btn_disabled.png");

        }
        //=================================================================
        private void Form1_Load(object sender, EventArgs e)
        {
            cmd_teste.BackColor = Color.Transparent;
            //botão

            cmd_teste.BackgroundImage = img_normal;
            
        }
        //===============================================================
        private void pic_teste_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Picture Box Clicada!");
        }

        //===============================================================
        private void cmd_teste_MouseEnter(object sender, EventArgs e)
        {
            //altera imagem para high
            cmd_teste.BackgroundImage = img_high;
        }
        //===============================================================
        private void cmd_teste_MouseLeave(object sender, EventArgs e)
        {
            //retorna ao aspecnto normal quando o mouse sair 
            cmd_teste.BackgroundImage = img_normal;
        }
        //===============================================================
        private void cmd_teste_Click(object sender, EventArgs e)
        {
            //back buffer é do directx
            //cria uma folha em branco
            Bitmap imgback = new Bitmap(pic_teste.Width, pic_teste.Height);

            Graphics desenhador = Graphics.FromImage(imgback);

            //atibuir uma cor de fundo a imagem
            desenhador.Clear(Color.White);

            Pen lapis = new Pen(Color.Black, 3);
            Pen lapis_vermelho = new Pen(Color.Red, 3);

            //desenhar uma linha
            ////horizontal
            //desenhador.DrawLine(lapis, new Point(50, 100), new Point(350, 100));

            ////vertical
            //desenhador.DrawLine(lapis, new Point(100, 20), new Point(100, 300));

            ////obliqua =  diagonal
            //desenhador.DrawLine(lapis, new Point(20, 20), new Point(250, 250));

            //desenhador.DrawLine(lapis, new Point(-100, -80), new Point(180, 200));

            //desenha linhas seguindas
            //Point[] pontos = new Point[] {
            //    new Point(50,50),
            //    new Point(100,80),
            //    new Point(100,150),
            //    new Point(400,150),
            //    new Point(200,200),
            //    new Point(200,20)
            //};
            //desenhador.DrawLines(lapis, pontos);

            //desenhador um retangulo
            //desenhador.DrawRectangle(lapis, new Rectangle(50, 80, 300, 80));
            //desenhador.DrawRectangle(lapis, new Rectangle(80, 30, 70, 280));

            //desenhar uma circunferência
            //desenhador.DrawRectangle(lapis_vermelho, new Rectangle(100, 100, 200, 200));
            //desenhador.DrawEllipse(lapis, new Rectangle(100, 100,200,200));

            Brush pincel_1 = new SolidBrush(Color.Red);
            Brush pincel_2 = new LinearGradientBrush(new Point(150, 50), new Point(250, 50), Color.Red, Color.Yellow);
            Brush pincel_3 = new SolidBrush(Color.Yellow);

            //desenhador.FillRectangle(pincel_1, new Rectangle(50, 50, 100, 250));
            //desenhador.FillRectangle(pincel_2, new Rectangle(150, 50, 100, 250));
            //desenhador.FillRectangle(pincel_3, new Rectangle(250, 50, 300, 250));

            //desenhador.FillEllipse(pincel_1, new Rectangle(50, 50, 300, 200));

            Rectangle ret = new Rectangle(50,50, 300, 200);
            desenhador.FillRectangle(pincel_3, ret);
            desenhador.DrawRectangle(lapis, ret);

            //apresenta a imagem final
            pic_teste.BackgroundImage = imgback;

        }
        //===============================================================
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
