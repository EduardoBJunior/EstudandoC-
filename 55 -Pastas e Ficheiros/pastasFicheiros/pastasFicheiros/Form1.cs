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

namespace pastasFicheiros
{
    public partial class Form1 : Form
    {
        // string global para a definição do local da pasta
        //string pasta_config = @"C:\config\";

        //string  global para gravar em Meus documentos do Windows
        string pasta_config;
        string ficheiro_config = "config.dat";
        public Form1()
        {
            InitializeComponent();
            //encontrar local da pasta Meus documentos
            pasta_config = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\config\";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            GravarConfiguracoes();
            MessageBox.Show("Configurações Gravadas com Sucesso");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //verifica se o ficherito config.dat existe
            if (!File.Exists(pasta_config + ficheiro_config))
            {
                GravarConfiguracoes();
            }
            /// carregamento das configurações 
            StreamReader ficheiro = new StreamReader(pasta_config+ficheiro_config,Encoding.Default);
            txtb_nome.Text = ficheiro.ReadLine();
            data_hora.Value = Convert.ToDateTime(ficheiro.ReadLine());
            ficheiro.Dispose();
        }
        private void GravarConfiguracoes()
        {
            
            // verifica se existe a pasta config 
            // se não existir, crie
            if (!Directory.Exists(pasta_config))
                Directory.CreateDirectory(pasta_config);

            StreamWriter ficheiro = new StreamWriter(pasta_config + ficheiro_config, false, Encoding.Default);
            ficheiro.WriteLine(txtb_nome.Text);
            ficheiro.WriteLine(data_hora.Value.ToShortDateString());
            ficheiro.Dispose();
        }
    }
}
