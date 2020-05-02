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

namespace AgendaSQL
{
    public partial class frmAdicionarEditar : Form
    {
        int id_contato;
        bool editar;
        //============================================================
        public frmAdicionarEditar(int id_contato = -1)
        {
            InitializeComponent();
            this.id_contato = id_contato;

            // definir se irá adicionar ou editar o registro
            editar = id_contato == -1 ? false : true;
        }
        //============================================================
        private void frmAdicionarEditar_Load(object sender, EventArgs e)
        {
            //apresenta os dados do contato, se necessario atualiza os dados
            if (editar)
            {
                ApresentaContato();
            }

        }
        //============================================================
        private void ApresentaContato()
        {
            //apresenta o contato a ser editado
            SqlCeConnection ligacao = new SqlCeConnection("Data Source ="+vars.base_dados);
            ligacao.Open();
            DataTable dados = new DataTable();
            SqlCeDataAdapter adaptador = new SqlCeDataAdapter("SELECT * FROM contatos WHERE id_contato = "+ id_contato, ligacao);

            adaptador.Fill(dados);
            ligacao.Dispose();

            //colocar os dados nos txtbox
            txtb_nome.Text = dados.Rows[0]["nome"].ToString();
            txtb_telefone.Text = dados.Rows[0]["telefone"].ToString();

            
        }
        //============================================================
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //============================================================
        private void btnGravar_Click(object sender, EventArgs e)
        {
            SqlCeConnection ligacao = new SqlCeConnection("Data Source = " + vars.base_dados);
            ligacao.Open();


            //grava novo registro ou edita registro existente

            #region Verificações
            //verifica se os cmapos estão preenchidos 
            if (txtb_nome.Text == ""||txtb_telefone.Text =="")
            {
                MessageBox.Show("Campo em brancao, Penncha os campos.");
                return; 

            }
            #endregion

            //----------------------------------------------
            #region Novo Contato
            if (!editar)
            {
                //buscar o id contato ja existente na tabela

               // ele apagou (SqlCeCommand comando = new SqlCeCommand("SELECT max(id_contato) as maxid from contatos",ligacao);) para colocar a Sql Adaptador

                SqlCeDataAdapter adaptador = new SqlCeDataAdapter("SELECT max(id_contato) as maxid from contatos", ligacao);

                DataTable dados = new DataTable();
                adaptador.Fill(dados);
                //verifica se o valor é nulo
                if (DBNull.Value.Equals(dados.Rows[0][0]))
           
                    id_contato = 0;
            
                else
                    id_contato = Convert.ToInt16(dados.Rows[0][0]) + 1;

                //gravar o novo contato na base de dados 
                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = ligacao;

                //parametros
                comando.Parameters.AddWithValue("@id_contato", id_contato);
                comando.Parameters.AddWithValue("@nome", txtb_nome.Text);
                comando.Parameters.AddWithValue("@telefone", txtb_telefone.Text);
                comando.Parameters.AddWithValue("@atualizacao", DateTime.Now);

                //verifica se ja existe um contato  com o mesmo nome e telefone 
                adaptador = new SqlCeDataAdapter();
                dados = new DataTable();
                comando.CommandText = "SELECT * FROM  contatos WHERE nome = @nome AND telefone =@telefone";
                adaptador.SelectCommand = comando;

                adaptador.Fill(dados);

                if (dados.Rows.Count !=0)
                {
                    //MessageBox.Show("Já exisite um registro com o mesmo nome e telefone!");
                    //return;

                    if (MessageBox.Show("Ja existe um registro com o mesmo nome e telefone!"+Environment.NewLine+" Deseja gravar as alterações?","Atenção",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)
                    {
                        return;
                    }
                    else
                    {

                    }
                }
                // texto da query
                comando.CommandText ="INSERT INTO contatos VALUES ("+
                    "@id_contato,@nome,@telefone,@atualizacao)";


                comando.ExecuteNonQuery();


                comando.Dispose();
                ligacao.Dispose();

                MessageBox.Show("contato adicionado com sucesso ");

                //limpar os campos 
                txtb_nome.Text = "";
                txtb_telefone.Text = "";
                txtb_nome.Focus();

                //comando.CommandText = 
                //    "INSERT INTO  contatos VALUES ("+
                //    id_contato+ ", "+
                //    "'" + txtb_nome.Text + "'"+", "+
                //    "'" + txtb_telefone.Text + "'"+", "+
                //    "'20160320')";


            }
            #endregion

            //---------------------------------------
            #region Editar Contato
            else
            {
                //edita o caontato na base de dados
                
                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = ligacao;

                //parametros
                comando.Parameters.AddWithValue("@id_contato", id_contato);
                comando.Parameters.AddWithValue("@nome", txtb_nome.Text);
                comando.Parameters.AddWithValue("@telefone", txtb_telefone.Text);
                comando.Parameters.AddWithValue("@atualizacao",DateTime.Now);

                //verifica se ja existe registro com o mesmo nome com id_ contato diferente

                DataTable dados = new DataTable();
                comando.CommandText = "SELECT * FROM contatos WHERE nome = @nome AND id_contato <> @id_contato";
                SqlCeDataAdapter adaptador = new SqlCeDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(dados);
                
                if (dados.Rows.Count!=0)
                {
                    // foi enconrtado um registro com este nome e e nmero 
                    if (MessageBox.Show("Já existe um contato registrado, deseja realmente Gravar ?", "Atenção",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)
                    {
                        return;
                    }
                    //editar o registro selecionado
                    comando.CommandText = "UPDATE contatos SET nome = @nome, telefone =@telefone, atualizacao=@atualizacao WHERE id_contato = @id_contato";

                    comando.ExecuteNonQuery();

                    //fecha o quadro
                    this.Close();

                }
                else
                {
                    if (MessageBox.Show("Realmente deseja atualizar o Nome do Contato para "+txtb_nome.Text+"?", "Atenção",MessageBoxButtons.YesNo,MessageBoxIcon.Information) ==DialogResult.No)
                    {
                        return;
                    }
                    comando.CommandText = "UPDATE contatos SET nome =@nome, atualizacao =@atualizacao,telefone=@telefone WHERE id_contato =@id_contato";

                    comando.ExecuteNonQuery();

                    this.Close();
                }
            }
            #endregion
        }
    }
}
