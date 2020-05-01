using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaSQL
{
    public partial class frmMenu : Form
    {
        //==========================================================================
        public frmMenu()
        {
            InitializeComponent();
            lbVersao.Text = vars.versao;
        }
        //==========================================================================
        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair da aplicação?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            //Sair da aplicação apos a condição 
            Application.Exit();
        }
        //====================================================================================
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Abrir o quadro para  adicionar e alterar um registro
            frmAdicionarEditar TelaAdicionarRemover = new frmAdicionarEditar();
            TelaAdicionarRemover.ShowDialog();
        }
        //====================================================================================
        private void button1_Click(object sender, EventArgs e)
        {
            //abrir uma tela para apresentar os registros
            frmResultado f = new frmResultado();
            f.ShowDialog();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisa f = new frmPesquisa();
            f.ShowDialog();

            // executa a pesquisa se o quandro não foi cancelado

            if (f.cancelado) 
            {
                f.Dispose();
                return;
            }
             
            //executa a pesquisa
            
            frmResultado ff = new frmResultado(f.texto_pesquisa);
            ff.ShowDialog();

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            //apaga todos os registros 

            if (MessageBox.Show("Deseja apagar todo os registros?", "Atenção",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.No)
            {
                return;
            }

            //elimina todos os registros  da base de dados
            SqlCeConnection ligacao = new SqlCeConnection("Data Source = " + vars.base_dados);
            ligacao.Open();

            SqlCeCommand comando = new SqlCeCommand("DELETE FROM contatos", ligacao);
            comando.ExecuteNonQuery();


            ligacao.Dispose();

            //
            MessageBox.Show("Todos os dados foram apagados do banco de dados");
        }
    }
}
