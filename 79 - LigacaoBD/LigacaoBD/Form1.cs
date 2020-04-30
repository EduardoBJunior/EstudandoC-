using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Windows.Forms;


namespace LigacaoBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ligar
            SqlCeConnection ligacao = new SqlCeConnection(@"Data Source= C:\Users\MetaTreinamento\Documents\MEGA\Eduardo\Estudo\João Ribeiro\EstudandoCsharp\74 - Introdução Banco de dados\teste.sdf");
            ligacao.Open();
            
            //recolher  | executar operações 
            DataTable dados = new DataTable();
            SqlCeDataAdapter operario = new SqlCeDataAdapter("SELECT * FROM Filmes",ligacao);
            operario.Fill(dados);

            //fechar resultados
            ligacao.Close();

            // apresentar resultados
            foreach (DataRow linha in dados.Rows)
            {
                lista_dados.Items.Add(linha["Titulo"].ToString() + " - " + linha["Diretor"].ToString() + " - " + linha["Ano"].ToString()); 
            }
        }
    }
}
