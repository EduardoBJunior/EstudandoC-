using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlServerCe;
using System.IO;
using System.Text;
using System.Windows.Forms;
//================================================================
//Classe que permite  gerir base de dados 
// versão 1.0.0
//================================================================
namespace GestorBD
{
    //================================================================
    public class cl_GestorBD
    {
        SqlCeConnection conexao;
        SqlCeCommand comando;
        SqlCeDataAdapter adaptador;

        SqlCeDataAdapter adaptador_temp;

        string strConn = "";
        string pasta_bd = @"C:\Users\MetaTreinamento\Documents\MEGA\Eduardo\Estudo\João Ribeiro\EstudandoCsharp\116-ClasseGestoraBaseDados\";
        string bd_password = "123456";
        
        //cria a Class de parametros de SQL
        public class SQLParametro
        {
            public string parametro { get; set; }
            public object valor { get; set; }
            
            public SQLParametro(string parametro, object valor)
            {
                this.parametro = parametro;
                this.valor = valor;
            }
        }



        //================================================================
        public cl_GestorBD()
        {
             
        }
        
        
        //================================================================
        public void CriarBaseDados(string base_dados, List<string> instrucoes, bool verirficar_ficheiro = false)
        {
            //---------------------------------------------
            #region Criar Ficheiro  
            
            //criar base de dados

            //---------------------------------------------
            #region verificação da existencia de ficheiro da base de dados

            if (verirficar_ficheiro)
            {
                //executa a verificação
                if (File.Exists(base_dados))
                {
                    if (MessageBox.Show("Existe uma Base de dados com o mesmo nome. "+Environment.NewLine+"Deseja substituir a base de dados Exixtente?", "Atenção", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) ==DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        //vai apagar o Ficheiro existente
                        try
                        {
                            File.Delete(base_dados);
                        }
                        catch 
                        {
                            MessageBox.Show("Ocorreu um erro ao eliminar a base de dados.");
                            return;
                        }
                    }
                }
            }

            #endregion
            //---------------------------------------------

            //contruição da connectionString
            StringBuilder str = new StringBuilder();
            str.Append("Data source = ");
             
            //nome da base de dados
            str.Append(base_dados);

            //verificar se tem password
            if (bd_password!= "")
            {
                str.Append("; Password = "+ bd_password);
            }


            //criação da base de dados 
            SqlCeEngine motor = new SqlCeEngine(str.ToString());
            motor.CreateDatabase(); 

            MessageBox.Show("Base de dados Criada Com sucesso.");

            #endregion

            //---------------------------------------------
            #region criação das tabelas

            

            conexao = new SqlCeConnection(str.ToString());
            conexao.Open();
            comando = new SqlCeCommand();
            comando.Connection = conexao;


            //executa as intruções  para criar as tabelas
            str = null;
            foreach(string item in instrucoes)
            {
                if (item.StartsWith("CREATE TABLE"))
                {
                    //inicia a construção da query
                    str = new StringBuilder();
                    str.Append(item);
                }
                else if (item== "FIM")
                {
                    //fecha a criação da query e executa
                    comando.CommandText = str.ToString();
                    comando.ExecuteNonQuery();
                }
                else
                {
                    //adicionar isntrução  ao StringBuilder
                    str.Append(item);
                } 
            }

            //fecha o comando e a ligação
            comando.Dispose();
            conexao.Dispose();
            #endregion
        }

        //================================================================
        //construtor 
        public cl_GestorBD(string base_dados)
        {
            //definir a connectionString da conexao
            //strConn = "Data source = " + pasta_bd + base_dados + ".sdf; Password = " + bd_password;

            StringBuilder str = new StringBuilder();

            //define a base da strConn
            str.Append("Data source = ");

            //se existe pasta/localização definida ..
            if (pasta_bd != "")
            {
                str.Append(pasta_bd);
            }

            //acrescenta o nome do ficheiro da base de dados
            str.Append(base_dados + ".sdf");

            //Adiciona a password se necessario
            if (bd_password != "")
            {
                str.Append("; Password = " + bd_password);
            }

            //Define a strConn
            strConn = str.ToString();


        }

        //================================================================
        //metodo para pesquisa da base de dados
        public DataTable EXE_READER(string query, List<SQLParametro> parametros = null)
        {
            DataTable dados = new DataTable();

            adaptador = new SqlCeDataAdapter(query, strConn);

            adaptador.SelectCommand.Parameters.Clear();


            //executar a query
            try
            {
                //inserir os paramentros na query 
                if (parametros!=null)
                {
                    foreach (SQLParametro p in parametros)
                    {
                        adaptador.SelectCommand.Parameters.AddWithValue(p.parametro, p.valor);
                    }
                }

                adaptador.Fill(dados);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro -->" + ex.Message);
                
            }
            

            adaptador.Dispose();

            return dados;
        }
        //================================================================

        public void EXE__NON_QUERY(string query, List<SQLParametro> parametros = null)
        {
            // executa query do tipo insert, delear, update, creare table, etc.

            conexao = new SqlCeConnection(strConn);
            conexao.Open();
            comando = new SqlCeCommand(query,conexao);
            comando.Parameters.Clear(); 

            try
            {
                //adição de parametros no comando

                if (parametros != null)
                {
                    foreach(SQLParametro p in parametros)
                    {
                        comando.Parameters.AddWithValue(p.parametro, p.valor);
                    }
                }
                //executar a query
                comando.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR : " +ex.Message);
            }
            // destruir a ligação e o comando
            comando.Dispose();
            conexao.Dispose();
        }
        //================================================================
        public int ID_DISPONIVEL(string tabela,string coluna)
        {
            //devolve o id dosponivel par ao proximo registro

            int idtemp = -1;
            string query = "SELECT MAX("+ coluna +") AS MaxID FROM "+ tabela;

            DataTable dados = new DataTable();
            
            adaptador = new SqlCeDataAdapter(query, strConn);
            
            adaptador.Fill(dados);
            //verifica se pe DBnull ou não 
            if (dados.Rows.Count != 0)
            {
                if (DBNull.Value.Equals(dados.Rows[0][0]))
                {
                    idtemp = 0;
                }
                else
                {
                    idtemp = Convert.ToInt16(dados.Rows[0][0]) + 1;
                }
            }

            return idtemp;
        }
        //================================================================
        //prepararar uma  data table 
        public DataTable PREPARAR_DATATABLE(string query)
        {
            //prepara a data table  para atualização ou inserção de dados
            adaptador_temp = new SqlCeDataAdapter(query, strConn);
            DataTable dados = new DataTable();

            try
            {
                adaptador_temp.Fill(dados);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro : " + ex.Message);
            }

            return dados;
        }
        //================================================================
        //Atualizar a base de dados com os novos dados
        public void GRAVAR_DATATABLE(DataTable dados)
        {
            //atualiza a informação na base de dados
            SqlCeCommandBuilder cmd = new SqlCeCommandBuilder(adaptador_temp);
            adaptador_temp.UpdateCommand = cmd.GetUpdateCommand();

            try
            {
                adaptador_temp.Update(dados);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: "+ex.Message);
            }
            adaptador_temp.Dispose();

        }
        //================================================================
        //Limpar espaço de armazxenamento
        public bool Compactar_Base_Dados()
        {
            bool concluido = false;
            //compacta a base de dados
            try
            {
                SqlCeEngine motor = new SqlCeEngine();
                motor.LocalConnectionString = strConn;
                motor.Compact(strConn);
                concluido = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: "+ex.Message);
            }

            return concluido;
        }
    }
}
