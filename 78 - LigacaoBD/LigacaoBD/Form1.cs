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
            //ligação a base de dados

            SqlCeConnection comunicarBanco = new SqlCeConnection();
            comunicarBanco.ConnectionString = @"Data Source=C:\Users\MetaTreinamento\Documents\MEGA\Eduardo\Estudo\João Ribeiro\EstudandoCsharp\74 - Introdução Banco de dados\teste.sdf";
            comunicarBanco.Open();
            lb_resultado.Text = "Ligação efetuada com sucesso.";
            
            //Criação de consulta a base de dadso há tabela Filmes
            SqlCeDataAdapter adaptar = new SqlCeDataAdapter("select * from Filmes",comunicarBanco);
            DataTable dados = new DataTable();
            adaptar.Fill(dados);
            comunicarBanco.Close();
            //mostra a quantidade de linhas adicionardas na label
            lb_resultado.Text = dados.Rows.Count.ToString();    
        }
    }
}
