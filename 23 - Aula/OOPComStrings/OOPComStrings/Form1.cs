using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPComStrings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            string frase = "Este tipo de variavel é alfanumérico";

            //caixa_texto.Text = frase + "(Estra frase contém" + frase.Length + " caracteres.)";

            //caixa_texto.Text = frase.Substring(5);
            //bool resultado = frase.Contains("Este");

            //caixa_texto.Text = resultado.ToString();

            //verifica se existe no final da frase
            //bool resultado = frase.EndsWith(".");

            //verifica se existe no inicia da frase 
            //bool resultado = frase.StartsWith(".");

            //Trim remove os espaços                        
            //caixa_texto.Text = frase.Trim();

            //int x = frase.LastIndexOf('e');

            //string nome = "Eduardo Brandão";
            //string apelido = "Dudu ";
            //string nome_completo = nome.Insert(8, apelido);

            //replace - substitui letras
            //string final = nome.Replace('a', ' ');

            // String arrays - no local especifico

            string itens = "joão, antonio, Aline,Eduardo,Lena,Fortes";

            string[] nomes = itens.Split(',');

            caixa_texto.Text = nomes[3];
        }
    }
}
