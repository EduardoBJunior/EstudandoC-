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
    public partial class frmInserirEditar : Form
    {
        public frmInserirEditar()
        {
            InitializeComponent();
            ConstroiLista();
            
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            //fechar
            this.Close();
        }

        private void ConstroiLista()
        {
            lista_contatos.Items.Clear();

            foreach(cl_contato contato in cl_geral.lista_contatos)
            {
                lista_contatos.Items.Add(contato.nome + " (" + contato.numero + ")");
            }
        }
    }
}
