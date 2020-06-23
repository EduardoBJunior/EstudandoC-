using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //criar uma tabala na base de dados 

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Server = METATREINAMENTO\SQLEXPRESS; Database = SQL_Teste; Trusted_Connection = True;";


            conexao.Open();

            MessageBox.Show(conexao.State.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Server = METATREINAMENTO\SQLEXPRESS; Database = SQL_Teste; Trusted_Connection = True;";
            conexao.Open();
            // Criar a tabela contatos
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "CREATE  TABLE contatos(id_contato    int not null primary key," +
                                                          "nome         nvarchar(50)," +
                                                          "telefone     nvarchar(20)," +
                                                          "atualizacao  datetime)";
            comando.ExecuteNonQuery();

            MessageBox.Show("Tabela criada com sucesso");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Adicionar registros a uma tabela
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Server = METATREINAMEnTO\SQLEXPRESS; Database = SQL_Teste; Trusted_Connection = True;";

            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;

            comando.Parameters.AddWithValue(@"id_contato", 1);
            comando.Parameters.AddWithValue(@"nome","Aline");
            comando.Parameters.AddWithValue(@"telefone","9876543210");
            comando.Parameters.AddWithValue(@"atualizacao", DateTime.Now);

            comando.CommandText = "INSERT INTO contatos VALUES (@id_contato, @nome, @telefone, @atualizacao)";
            comando.ExecuteNonQuery();
            
            comando.Dispose();
            conexao.Dispose();

            MessageBox.Show("Registro adicionado com sucesso");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Server = METATREINAMENTO\SQLEXPRESS; Database = SQL_Teste; Trusted_Connection = True";
            conexao.Open();

            SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * FROM contatos",conexao);
            DataTable dados = new DataTable();
            adaptador.Fill(dados);

            foreach (DataRow linha in dados.Rows)
            {
                MessageBox.Show(linha["nome"].ToString() +" --> "+linha["telefone"].ToString());
            }
        }
    }
}
