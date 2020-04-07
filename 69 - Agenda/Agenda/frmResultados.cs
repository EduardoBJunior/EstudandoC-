using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class frmResultados : Form
    {
        string texto;
        //==============================================================================================
        public frmResultados(string texto)
        {
            InitializeComponent();
            //definir o texto da pesquisa
            this.texto = texto.ToUpper();
        }
        //==============================================================================================
        private void frmResultados_Load(object sender, EventArgs e)
        {
            //executa a pesquisa e constroi lista
            ExecutaPesquisa();
        }
        //==============================================================================================
        private void ExecutaPesquisa()
        {
            //realiza a pesquisa e apresenta os dados
            List<cl_contato> lista_resultados = new List<cl_contato>();

            foreach (cl_contato contato in cl_geral.lista_contatos)
            {
                

                if (contato.nome.ToUpper().Contains(texto)||contato.numero.ToUpper().Contains(texto))
                {
                    lista_resultados.Add(contato);
                }
            }
            //apresentar os resultados na lista
            lista_final.Items.Clear();
            foreach (cl_contato contato in lista_resultados)
                lista_final.Items.Add(contato.nome + " ( " + contato.numero + " )");

            lb_nRegistros.Text = "Registros: " + lista_final.Items.Count;
            
        }
        //==============================================================================================
        private void btn_nova_pesquisa_Click(object sender, EventArgs e)
        {
            // pedir novo texto
            frmTextoPesquisa frm_txtpesquisa = new frmTextoPesquisa();
            frm_txtpesquisa.ShowDialog();

            //quando o quadrado é fechado 
            if (frm_txtpesquisa.cancelado) return;


            texto = frm_txtpesquisa.texto.ToUpper();

            ExecutaPesquisa();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
