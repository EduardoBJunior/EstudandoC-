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
            
            lista.Items.Add(documento.DefaultPageSettings.Bounds.X.ToString());
            lista.Items.Add(documento.DefaultPageSettings.Bounds.Y.ToString());
            lista.Items.Add(documento.DefaultPageSettings.Bounds.Width.ToString());
            lista.Items.Add(documento.DefaultPageSettings.Bounds.Height.ToString());

            //Preparar a impressão
            largura = documento.DefaultPageSettings.Bounds.Width;
            altura = documento.DefaultPageSettings.Bounds.Height;

            letra = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Pixel);
            cor = new SolidBrush(Color.Black);
            y = 50;
            num_frase = 1;

            ////Abrir janela de configuração da impressora 
            //if (CaixaSetup.ShowDialog() ==DialogResult.Cancel)
            //{
            //    return;
            //}
            //else
            //{
            //    documento.PrinterSettings = CaixaSetup.PrinterSettings; 
            //}

            ////Imprime os dados 
            //documento.Print();

            ////contar as paginas criadas 
            //paginas_criadas = 0;


            ////pré visualizar a impressão
            //visualizar.Document = documento;

            //visualizar.InvalidatePreview();

            caixa_visualizacao.Document = documento;
            caixa_visualizacao.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //avança para a pgina seguinte
            if (pagina == paginas_criadas) return;
            pagina++;
            visualizar.StartPage = pagina
                ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pagina == 0) return;    
            
            pagina--;
            visualizar.StartPage = pagina;
        }

        private void documento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //imprime os dados no documento
            while(num_frase <= 100)
            {
                e.Graphics.DrawString("Frase Numero " + num_frase.ToString()+" ",  letra, cor, new Point(50, y));
                y += 30;
                num_frase++;

                //sender o documento Chegou ao fundo da folha

                if (y >= altura -50)
                {
                    //mudar de pagina
                    y = 50;
                    e.HasMorePages = true;
                    paginas_criadas++;
                    break;
                }
            }


        }

        
    }
}
