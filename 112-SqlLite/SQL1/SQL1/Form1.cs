using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //    SQLiteConnection ligacao = new SQLiteConnection();
            //    SQLiteDataAdapter adaptador = new SQLiteDataAdapter();

            //Criar a base de dados no sqllite
            SQLiteConnection.CreateFile(@"C:\Users\MetaTreinamento\Documents\MEGA\Eduardo\Estudo\João Ribeiro\EstudandoCsharp\112-SqlLite\base.db");

            //estabelecer ligação com a base de dados
            //"Data source = [basededados]. db; Password= 1234567";

            SQLiteConnection ligacao = new SQLiteConnection();
            ligacao.ConnectionString = @"Data source= C:\Users\MetaTreinamento\Documents\MEGA\Eduardo\Estudo\João Ribeiro\EstudandoCsharp\112-SqlLite\base.db; Version=3;";
            ligacao.Open();


            //Criar uma tabela

            string query = "CREATE TABLE contatos(id_contato int,nome varchar(50),telefone varchar (20))";
            SQLiteCommand comando = new SQLiteCommand(query, ligacao);
            comando.ExecuteNonQuery();


            MessageBox.Show("OK");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQLiteConnection ligacao = new SQLiteConnection();
            ligacao.ConnectionString = @"Data source = C:\Users\MetaTreinamento\Documents\MEGA\Eduardo\Estudo\João Ribeiro\EstudandoCsharp\112-SqlLite\base.db; Version =3";
            ligacao.Open();

            string query = "INSERT INTO contatos VALUES (0,'Eduardo Brandão Junior','123123123'),(0,'Aline Fortes', '456456456')";
            SQLiteCommand comando = new SQLiteCommand(query, ligacao);
            comando.ExecuteNonQuery();
            ligacao.Dispose();

            MessageBox.Show("Dados gravados com sucesso");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SQLiteConnection ligacao = new SQLiteConnection();
            ligacao.ConnectionString = @"Data source = C:\Users\MetaTreinamento\Documents\MEGA\Eduardo\Estudo\João Ribeiro\EstudandoCsharp\112-SqlLite\base.db; Version =3";
            ligacao.Open();


            SQLiteDataAdapter adaptador = new SQLiteDataAdapter("SELECT * FROM contatos", ligacao);
            DataTable dados = new DataTable();
            adaptador.Fill(dados);

            foreach (DataRow linha in dados.Rows)
            {
                ltbox.Items.Add(linha["nome"].ToString() + " -> " + linha["telefone"].ToString());
            }

        }

    }
}
