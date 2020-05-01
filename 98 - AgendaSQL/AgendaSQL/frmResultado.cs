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
    public partial class frmResultado : Form
    {
        int id_contato;
        string item_pesquisa;

        //====================================================================================
        public frmResultado(string item_pesquisa ="")
        {
            InitializeComponent();
            this.item_pesquisa = item_pesquisa;
        }
        //====================================================================================
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            //fecha a tela
            this.Close();
        }
        //====================================================================================
        private void ConstruirGrid()
        {
            //contruir a grid de registros

            //ligar a bd
            SqlCeConnection ligacao =new  SqlCeConnection("Data source = " + vars.base_dados);
            ligacao.Open();

            string query = "SELECT * FROM contatos";
            if (item_pesquisa != "")
            {
                query = "SELECT * FROM contatos WHERE nome like @item OR telefone LIKE @item";
            }

            SqlCeCommand comando = new SqlCeCommand();
            comando.Parameters.AddWithValue("@item","%" + item_pesquisa+"%");
            comando.CommandText = query;
            comando.Connection = ligacao;

            SqlCeDataAdapter adaptador = new SqlCeDataAdapter();
            adaptador.SelectCommand = comando; 

            DataTable dados = new DataTable();
            adaptador.Fill(dados);

            dgv_resultado.DataSource = dados;

            //apresenta o numero de registros 
            lb_resultados.Text = "Resultados: " + dgv_resultado.Rows.Count;

            //esconder conulunas 
            //id_contato || atualizacao
            dgv_resultado.Columns[0].Visible = false;
            dgv_resultado.Columns["atualizacao"].Visible = false;


            //alterar as dimensões das colunas 
            dgv_resultado.Columns["nome"].Width = CalcularLargura(60);
            dgv_resultado.Columns["telefone"].Width = CalcularLargura(40);

            //Ativa ou desativa o botão
            btn_apagar.Enabled = false;
            btn_editar.Enabled = false;

        }
        //====================================================================================
        private void frmResultado_Load(object sender, EventArgs e)
        {
            ConstruirGrid();
        }
        //====================================================================================
        private void btn_apagar_Click(object sender, EventArgs e)
        {
            //eleiminar a linha selecionada
            SqlCeConnection ligacao = new SqlCeConnection("Data Source =" + vars.base_dados);
            ligacao.Open();
            SqlCeCommand comando = new SqlCeCommand("DELETE FROM contatos WHERE id_contato = "+ id_contato, ligacao);
            comando.ExecuteNonQuery();
            comando.Dispose();
            ligacao.Dispose();

            //reconstroi depois de apagado
            ConstruirGrid();

        }
        //====================================================================================
        private void dgv_resultado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_contato = Convert.ToInt16(dgv_resultado.Rows[e.RowIndex].Cells["id_contato"].Value);
            btn_apagar.Enabled = true;
            btn_editar.Enabled = true;
        }
        //====================================================================================
        private void btn_editar_Click(object sender, EventArgs e)
        {
            //edita o registro selecionado

            frmAdicionarEditar f = new frmAdicionarEditar(id_contato);
            f.ShowDialog();

            ConstruirGrid();
        }
        //====================================================================================
        private void dgv_resultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //====================================================================================
        private void btn_verRegistros_Click(object sender, EventArgs e)
        {
            // apresenta todos os registros de contato

            item_pesquisa = "";
            ConstruirGrid();
        }
        private int CalcularLargura(int percentagem)
        {

            // od comentados estavar no metodo "ContruirGrid"
            //// recebe o valor total do largura 100%
            //int dgvWidth = dgv_resultado.Size.Width;

            //// calcula  o valor de 30 %
            //double colnome = dgvWidth * 0.3;
            ////calcula o valor de 71%
            //double coltelefone = dgvWidth * 0.71;
            //dgv_resultado.Columns["nome"].Width = dgvWidth - (int)colnome;
            //dgv_resultado.Columns["telefone"].Width = dgvWidth - (int)coltelefone;

            int largura_grid = dgv_resultado.Width - 20;
            int resultado = (largura_grid * percentagem) / 100;
            return resultado;
        }
    }
}
