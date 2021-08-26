using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impressao1
{
    public partial class Form1 : Form
    {
        int largura, altura;

        Font letra;
        SolidBrush cor;
        int y =50;
        int num_frase=1;
        int pagina = 0;

        int paginas_criadas;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DA A INTRUÇÃO PARA IMPRESSÃO
            
            //Preparar a impressão
            largura = documento.DefaultPageSettings.Bounds.Width;
            altura = documento.DefaultPageSettings.Bounds.Height;

            letra = new Font("Arial", 40, FontStyle.Regular, GraphicsUnit.Pixel);
            cor = new SolidBrush(Color.Black);
            y = 100;
            num_frase = 1;

            documento.DefaultPageSettings.Landscape = true;

            caixa_visualizacao.Document = documento;
            caixa_visualizacao.ShowDialog();
        }


        private void documento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //e.Graphics.DrawString("txto", letra, cor, new Point(100, 100));

            string frase = "Esta frase é usada para testes.";
            SizeF dimencao = e.Graphics.MeasureString(frase, letra);

            //descoobre a altura da letra
            //MessageBox.Show(dimencao.Width.ToString() + " X " + dimencao.Height.ToString());
            
            //esqcreve uma frase
            e.Graphics.DrawString(frase, letra, cor, new Point(100, y));
            //adiciona 5 pixel de expassamento entre as frases  
            y += Convert.ToInt16(dimencao.Height + 5);
            
            e.Graphics.DrawString(frase, letra, cor, new Point(100, y));
            y += Convert.ToInt16(dimencao.Height + 5);

            e.Graphics.DrawString(frase, letra, cor, new Point(100, y));
            y += Convert.ToInt16(dimencao.Height + 5);

            e.Graphics.DrawString(frase, letra, cor, new Point(100, y));
            y += Convert.ToInt16(dimencao.Height + 5);

            e.Graphics.DrawString(frase, letra, cor, new Point(100, y));
            

            //desenhar  linha 
            e.Graphics.DrawLine(new Pen(Color.Red, 2), 
                                new Point(100 + (int)dimencao.Width, 100), 
                                new Point(100 + (int)dimencao.Width,y + (int)dimencao.Height));

        }

        
    }
}
