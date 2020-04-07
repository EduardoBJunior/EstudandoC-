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
        int indice;

        //=============================================================================================
        public frmInserirEditar()
        {
            InitializeComponent();
            ConstroiLista();
            
        }
        //=============================================================================================
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            //fechar
            this.Close();
        }
        //=============================================================================================
        private void ConstroiLista()
        {
            lista_contatos.Items.Clear();

            cl_geral.ConstroiListaContatos();

            foreach (cl_contato contato in cl_geral.lista_contatos)
            {
                lista_contatos.Items.Add($"{contato.nome} ({contato.numero})");

                //outra forma que o Leando me mostrou de manipuação de string

                //string valor = String.Format("{0} ({1})", contato.nome, contato.numero);
                //lista_contatos.Items.Add(valor);

                //atualizar o numero de registro
                lb_nRegistros.Text = "Registros: " + lista_contatos.Items.Count;

                //impedir  edição e eliminação do registro
                btn_apagar.Enabled = false;
                btn_editar.Enabled = false;
            }
        }
        //=============================================================================================
        private void LimparTxtBoxContato()
        {
            txbox_nome.Text = "";
            txtbox_numero.Text = "";
            txbox_nome.Focus();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            //inserir um registro na lista 

            //verifica se os campos estão preenchidos

            if (txbox_nome.Text == "" || txtbox_numero.Text == "") 
            {
                MessageBox.Show("Os campos não estão todos Preenchidos.");
                return;
            }
            //Verifica se existe registro  igual na lista
            foreach (cl_contato contato in cl_geral.lista_contatos)
            {
                if (contato.nome == txbox_nome.Text && contato.numero ==txtbox_numero.Text)
                {
                    MessageBox.Show("Erro este Contato ja Existe! ");
                    return;
                }
            }
            //verificar se ó índice ta listbox é diferente de -1 (que índica que tem algum contato selecionado) sendo verdadeiro, ele chama o método de "InserirContatoLista" utilizando os índices.
            if (lista_contatos.SelectedIndex != -1)
            {
                cl_geral.IserirContatoLista(txbox_nome.Text, txtbox_numero.Text, lista_contatos.SelectedIndex);
                cl_geral.GravarFicheiro();
                ConstroiLista();
                LimparTxtBoxContato();
                return;
            }
            //gravar novo registro 
            cl_geral.GravarNovoResgistro(txbox_nome.Text, txtbox_numero.Text);

            //atualizar a lista de Contatos
            ConstroiLista();

            //prepra os campos para novo registro
          
            LimparTxtBoxContato();
            
        }
        //=============================================================================================
        private void lista_contatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //selecionar um contato
          // MessageBox.Show(lista_contatos.SelectedIndex.ToString());

            //verificar se indice é = a -1
            if (lista_contatos.SelectedIndex == -1) return;

            //seleciona um indice da lista
            indice = lista_contatos.SelectedIndex;

            btn_apagar.Enabled = true;
            btn_editar.Enabled = true;

        }
        //=============================================================================================
        private void btn_apagar_Click(object sender, EventArgs e)
        {
            //apaga o registro selecionado

            //1º eliminar o registro da lista
            cl_geral.lista_contatos.RemoveAt(indice);
            //2º renovar o ficheiro
            cl_geral.GravarFicheiro();
            //3º reconstruir a lista de contatos
            ConstroiLista();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            var contato = cl_geral.BuscarContatoLista(lista_contatos.SelectedIndex);
            txbox_nome.Text = contato.nome;
            txtbox_numero.Text = contato.numero;
            btn_salvar.Enabled = true;
            txbox_nome.Focus();
        }

       
    }
}
