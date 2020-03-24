using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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
            SaveFileDialog caixa = new SaveFileDialog();
            caixa.Title = "Gravar Ficheiro";
            caixa.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            caixa.Filter = ("TXT Files |*.txt | RTF files |* .rtf");

            if (caixa.ShowDialog() == DialogResult.Cancel) return;
            {
                // gravar o arquivo
                string local = caixa.FileName;

                StreamWriter file = new StreamWriter(local,false,Encoding.Default);
                file.WriteLine("Teste");
                file.Dispose();

            }
            
        }
    }
}
