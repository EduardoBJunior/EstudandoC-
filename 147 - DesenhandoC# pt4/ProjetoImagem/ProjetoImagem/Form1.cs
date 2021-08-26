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
            Pen lapis = new Pen(Color.Gray,1);

            //string texto = "Esta frase é para desenhar.";
            //Font letra = new Font("Courrier", 40,FontStyle.Bold | FontStyle.Italic,GraphicsUnit.Pixel);
            //Brush cor_principal = new SolidBrush(Color.FromArgb(200,180,0));
            //Brush cor_sombra = new SolidBrush(Color.Black);

            //Point inicio = new Point(50, 50);
            //Point inicio_sombra = new Point(53, 53);

            //desenhador.DrawString(texto, letra, cor_sombra, inicio_sombra);
            //desenhador.DrawString(texto, letra, cor_principal, inicio);

            //determinar um local especifico para que o texto aparece 
            string texto = "Lorem ipsum luctus odio lectus nulla vestibulum faucibus porta mi volutpat.";
            Brush cor = new SolidBrush(Color.Black);
            Font letra = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Pixel);
            Rectangle ret = new Rectangle(50, 50, 500, 100);
            
            //Alinhamento do texto
            StringFormat alinhamento = new StringFormat();
            alinhamento.Alignment = StringAlignment.Center;// near = perto ou a esquerda
            alinhamento.LineAlignment = StringAlignment.Center;// near = perto ou a top
            // cria a borda
            desenhador.DrawRectangle(lapis, ret);
            //cria o retangulo com o texto dentro
            desenhador.DrawString(texto, letra, cor, ret,alinhamento);


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
