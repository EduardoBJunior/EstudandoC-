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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();

        }

        private void bnt_inserir_editar_Click(object sender, EventArgs e)
        {

            frmInserirEditar formularioInserir = new frmInserirEditar();
            formularioInserir.ShowDialog();
        }

               private void btn_sair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bnt_pesquisar_Click(object sender, EventArgs e)
        {
            //Abrir o Quando de Pesquisa
            frmTextoPesquisa f = new frmTextoPesquisa();
            f.ShowDialog();

            //quando fecha o quadro, verifica se foi cancelado
            if (f.cancelado) return;

            //abrir o quandro com resultado da pesquisa
            frmResultados frm_resultados = new frmResultados(f.texto);
            frm_resultados.ShowDialog();

        }
    }
}
