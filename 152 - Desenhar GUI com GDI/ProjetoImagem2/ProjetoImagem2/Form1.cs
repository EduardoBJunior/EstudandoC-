using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoImagem2
{
    public partial class Form1 : Form
    {
        Image imgFrame;
        int largura, altura;
        //armazena o tamanho mazximo da area de trabalho 
        int larguraTela = Screen.PrimaryScreen.WorkingArea.Width;
        int alturaTela = Screen.PrimaryScreen.WorkingArea.Height;
        //===================================================================================================
        public Form1()
        {
            InitializeComponent();
            imgFrame = Image.FromFile(Environment.CurrentDirectory + @"\imagens\frame.png");
            this.DoubleBuffered = true;
            largura = this.ClientSize.Width;
            altura = this.ClientSize.Height; 
            DesenhaGUI();

        }
        //===================================================================================================
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        //===================================================================================================
        private void DesenhaGUI()
        {

            //desenahar o findo do form1 
            Bitmap imgback = new Bitmap(largura,altura);
            Graphics desenhador = Graphics.FromImage(imgback);

            //desenhar os cantos
            // 40x40  -200x200
            //160X40

            //desenhador o canto superiror esquerdo
            desenhador.DrawImage(imgFrame, new Rectangle(0, 0, 40, 40), new Rectangle(0,0,40,40), GraphicsUnit.Pixel);
            //desenhador o canto superiror direito
            desenhador.DrawImage(imgFrame, new Rectangle(largura-40, 0, 40, 40), new Rectangle(160, 0, 40, 40), GraphicsUnit.Pixel);

            //desenhador o canto inferior esquerdo
            desenhador.DrawImage(imgFrame, new Rectangle(0, altura-40, 40, 40), new Rectangle(0, 160, 40, 40), GraphicsUnit.Pixel);

            //desenhador o canto inferior direito
            desenhador.DrawImage(imgFrame, new Rectangle(largura-40, altura - 40, 40, 40), new Rectangle(160,160, 40, 40), GraphicsUnit.Pixel);

            //desenhar  linhas horizontais
            desenhador.DrawImage(imgFrame, new Rectangle(40, 0, largura - 80, 40), new Rectangle(40, 0, 120, 40), GraphicsUnit.Pixel);

            desenhador.DrawImage(imgFrame, new Rectangle(40, altura -40 , largura - 80, 40), new Rectangle(40, 160, 120, 40), GraphicsUnit.Pixel);

            //desenhar Linhas Verticais

            desenhador.DrawImage(imgFrame, new Rectangle(0,40,40,altura-80), new Rectangle(0, 40, 40, 120), GraphicsUnit.Pixel);
            desenhador.DrawImage(imgFrame, new Rectangle(largura -40, 40,40, altura - 80), new Rectangle(160, 40, 40, 120), GraphicsUnit.Pixel);

            //definir a imagem de fundo do form
            this.BackgroundImage = imgback;
        }

      

        private void Form1_Resize(object sender, EventArgs e)
        {
            largura = this.ClientSize.Width;
            altura = this.ClientSize.Height;

            //define tamanho minimo da tela 
            this.MinimumSize = new Size(100,120);
            //verifica o tamanho da tela e reposiciona caso o form seja maior que atela principal 
            if (largura > larguraTela  || altura > alturaTela)
            {
                this.Width = Screen.PrimaryScreen.WorkingArea.Width;
                this.Height = Screen.PrimaryScreen.WorkingArea.Height;
                this.Location = new Point(0, 0);
            }

            DesenhaGUI();



        }
    }
}
