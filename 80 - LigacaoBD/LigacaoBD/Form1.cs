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
            try { 
            //buscar os dados da tabela
            SqlCeConnection ligacao = new SqlCeConnection();
            ligacao.ConnectionString = "Data Source = C:\\Users\\MetaTreinamento\\Documents\\MEGA\\Eduardo\\Estudo\\João Ribeiro\\EstudandoCsharp\\80 - LigacaoBD\\"+ txbx_nomeDb.Text +".sdf";
            ligacao.Open();

            //Buscar Dados

            DataTable dados = new DataTable(); //cria uma tabela para receber os dados
            SqlCeDataAdapter operario = new SqlCeDataAdapter("SELECT * FROM pessoa",ligacao);//cria o objeto operario para receber o resultado do select
            operario.Fill(dados);//preenche a tabela  de dados com a consulta

                //apresnetar os dados
              lista_dados.Items.Clear();
            foreach (DataRow linha in dados.Rows)
            {
                lista_dados.Items.Add(linha["nome"].ToString() + " - " + linha["morada"].ToString() + " - " + linha ["telefone"].ToString());
            }
            }
            catch
            {
                lista_dados.Items.Clear();
                MessageBox.Show("Aconteceu um Erro");
            }

        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            //inserir registro 
            //nome,morada, telefone
            try
            {
                //abrir Ligação com o banco
                SqlCeConnection ligacao = new SqlCeConnection();
                ligacao.ConnectionString = @"Data Source = C:\Users\MetaTreinamento\Documents\MEGA\Eduardo\Estudo\João Ribeiro\EstudandoCsharp\80 - LigacaoBD\" + txbx_nomeDb.Text + ".sdf";
                ligacao.Open();

                string query = "INSERT INTO pessoa VALUES('Eduardo Brandão','Rua Marmore','4333289494')";
                SqlCeCommand operario = new SqlCeCommand(query, ligacao);
                operario.ExecuteNonQuery();

                //Fechar a ligação
                ligacao.Close();

            }
            catch
            {

                MessageBox.Show("aconteceu um erro na inserção de dados");
            }
            
         }
    }
}
