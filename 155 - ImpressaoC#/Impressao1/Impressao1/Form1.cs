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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DA A INTRUÇÃO PARA IMPRESSÃO
            
            lista.Items.Add(documento.DefaultPageSettings.Bounds.X.ToString());
            lista.Items.Add(documento.DefaultPageSettings.Bounds.Y.ToString());
            lista.Items.Add(documento.DefaultPageSettings.Bounds.Width.ToString());
            lista.Items.Add(documento.DefaultPageSettings.Bounds.Height.ToString());

            //Preparar a impressão
            largura = documento.DefaultPageSettings.Bounds.Width;
            altura = documento.DefaultPageSettings.Bounds.Height;

            documento.Print();
        }
        private void documento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //IMPRIME OS DADOS NO DOCUMENTO
            string texto = "Primeira Frase impressa.";
            Font letra = new Font("Arial", 14, FontStyle.Bold, GraphicsUnit.Pixel);
            SolidBrush cor = new SolidBrush(Color.Black);
            Rectangle rect = new Rectangle(0,100,largura,30);
            StringFormat alinhamento = new StringFormat();
            alinhamento.Alignment =  StringAlignment.Center;
            alinhamento.LineAlignment = StringAlignment.Center;

            List<string> lista = new List<string>()
            {
                "Frase numero um.",
                "Frase numero dois.",
                "Frase numero três.",
                "Frase numero quatro.",
                "Frase numero cinco.",
                "Frase numero seis."
            };

            //instrução para imprimir (desenhar) o texto na folha
            e.Graphics.DrawString(texto.ToUpper(), letra, cor, rect, alinhamento);

            int y = 140;
            foreach (string frase in lista)
            {
                e.Graphics.DrawString(frase, letra, cor, new Point(100, y));
                y += 40;
            }

            y += 50;

            alinhamento.Alignment = StringAlignment.Near;
            alinhamento.LineAlignment = StringAlignment.Near;
            string texto1 = "Este texto vai ser apresentado dentro de uma caixa de texto com o mesmo sindo formatado. Este texto vai ser apresentado dentro de uma caixa de texto com o mesmo sindo formatado. ";
            e.Graphics.DrawString(texto1, letra, cor, new Rectangle(100, y, 600, 200), alinhamento);
            e.Graphics.DrawRectangle(new Pen(Color.Red, 2), new Rectangle(100, y, 600, 200));
        }

        
    }
}
