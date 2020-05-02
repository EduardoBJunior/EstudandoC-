using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.IO;

namespace AgendaSQL
{
    //==========================================================================
    public static partial class vars
    {
        public static string versao = "v. 1.0.1";
        public static string pasta_dados;
        public static string base_dados;
        public static void Iniciar()
        {
            //mecanismos de iniciação
            pasta_dados = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\AgendaSQL\";

            //verifica se a pasta de dados existe se não existir ele cria
            if (!Directory.Exists(pasta_dados))
            {
                Directory.CreateDirectory(pasta_dados);
            }
            //verifica se a base de dados existe
            base_dados = pasta_dados + "dados.sdf; Password ='123456'";
            if (!File.Exists(pasta_dados + "dados.sdf"))
                CriarBaseDados();






        }

        //==========================================================================
        public static void CriarBaseDados()
        {
            //criação da Base de dados
            SqlCeEngine motor = new SqlCeEngine("Data source = " + base_dados);
            motor.CreateDatabase();

            //criar estrutura da base de dados
            SqlCeConnection ligacao = new SqlCeConnection();
            ligacao.ConnectionString = "Data Source = " + base_dados;
            ligacao.Open();

            SqlCeCommand comando = new SqlCeCommand();
            comando.CommandText = 
                "CREATE TABLE contatos(" +
                "id_contato         INT NOT NULL PRIMARY KEY," +
                "nome               nvarchar(50)," +
                "telefone           nvarchar(20)," +
                "atualizacao        datetime)";

            comando.Connection = ligacao;
            comando.ExecuteNonQuery();

            comando.Dispose();
            ligacao.Dispose();
        }
    }


}
