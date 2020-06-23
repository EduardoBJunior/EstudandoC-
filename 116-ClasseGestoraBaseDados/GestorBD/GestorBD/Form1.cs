using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestorBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //instancia a classe gestra 
            cl_GestorBD gestor = new cl_GestorBD();

            //define as instruções das tabelas

            List<string> instrucoes = new List<string>()
            {
                //Tabela Clientes
                "CREATE TABLE clientes(",
                "id_cliente         int not null primary key,",
                "nome               nvarchar(50),",
                "telefone           nvarchar(20),",
                "atualizacao        datetime)",
                "FIM",

                //tabela Compras
                "CREATE TABLE compras (",
                "id_compra          int not null primary key,",
                "id_CLIENTE         int,",
                "produto            nvarchar(50),",
                "quantidade         int,",
                "preco_unidade      int,",
                "atualizacao        datetime,",
                "FOREIGN KEY(id_cliente) REFERENCES clientes(id_cliente) ON DELETE CASCADE)",
                "FIM"

            };



            gestor.CriarBaseDados(@"C:\Users\MetaTreinamento\Documents\MEGA\Eduardo\Estudo\João Ribeiro\EstudandoCsharp\116-ClasseGestoraBaseDados\loja.sdf",instrucoes, true);
            //Executar Comando
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //abertura da conexão com base de dados
            cl_GestorBD gestor = new cl_GestorBD("loja");

            
            //construção da lista do parametros
            List<cl_GestorBD.SQLParametro> parametros = new List<cl_GestorBD.SQLParametro>();
            
            //Parametro digitado na pesquisa
            parametros.Add(new cl_GestorBD.SQLParametro("@item_pesquisa", txtb_pesquisa.Text));

            //executa a query 
            DataTable dados = gestor.EXE_READER("SELECT * FROM clientes  WHERE nome = @item_pesquisa", parametros);

            //numero de linhas devolvidas
            MessageBox.Show(dados.Rows.Count.ToString());
        }

        private void bn_pesquisaSQLinject_Click(object sender, EventArgs e)
        {
            //abertura da conexão com base de dados
            cl_GestorBD gestor = new cl_GestorBD("loja");

            
            
            //executa a query 
            DataTable dados = gestor.EXE_READER("SELECT * FROM clientes  WHERE nome = '" + txtb_pesquisa.Text + "'");

            //numero de linhas devolvidas
            MessageBox.Show(dados.Rows.Count.ToString());
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            cl_GestorBD gestor = new cl_GestorBD("loja");

            //criar a lista de parametros
            List<cl_GestorBD.SQLParametro> parametros = new List<cl_GestorBD.SQLParametro>();

            parametros.Add(new cl_GestorBD.SQLParametro("@id_cliente", 1));
            parametros.Add(new cl_GestorBD.SQLParametro("@nome","Aline"));
            parametros.Add(new cl_GestorBD.SQLParametro("@telefone","987987987"));
            parametros.Add(new cl_GestorBD.SQLParametro("@atualizacao",DateTime.Now));

            gestor.EXE__NON_QUERY("INSERT INTO clientes VALUES (@id_cliente, @nome, @telefone, @atualizacao)",parametros);

            MessageBox.Show("Informação inserida");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtb_nome.Text =="" || txtb_telefone.Text =="")
            {
                MessageBox.Show("Erro! Preencha todos so campos", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //grvação do novo cliente na base de dados
            cl_GestorBD gestor = new cl_GestorBD("loja");

            //buscar o id_cliente disponivel
            int id_cliente = gestor.ID_DISPONIVEL("clientes", "id_cliente");

            List<cl_GestorBD.SQLParametro> parametros = new List<cl_GestorBD.SQLParametro>();

            parametros.Add(new cl_GestorBD.SQLParametro("@id_cliente", id_cliente));
            parametros.Add(new cl_GestorBD.SQLParametro("@nome", txtb_nome.Text));
            parametros.Add(new cl_GestorBD.SQLParametro("@telefone", txtb_telefone.Text));
            parametros.Add(new cl_GestorBD.SQLParametro("@atualizacao", DateTime.Now));

            gestor.EXE__NON_QUERY("INSERT INTO clientes  VALUES (@id_cliente, @nome, @telefone, @atualizacao)", parametros);

            MessageBox.Show("Inserido com campos digitaveis");
            

        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            //prepara uma data table
            cl_GestorBD gestor = new cl_GestorBD("loja");

            DataTable dados = gestor.PREPARAR_DATATABLE("SELECT * FROM clientes");

            foreach(DataRow linha in dados.Rows)
            {
                //alterar o telefone
                string novo_telefone = "(01) " + linha["telefone"].ToString();
                linha["telefone"] = novo_telefone;
            }

            gestor.GRAVAR_DATATABLE(dados);
        }

        private void bt_inserirInt_Click(object sender, EventArgs e)
        {
            //inserir novos clientes na base

            List<string> lista_nomes = new List<string>();
            lista_nomes.Add("nome 1");
            lista_nomes.Add("nome 2");
            lista_nomes.Add("nome 3");
            lista_nomes.Add("nome 4");
            lista_nomes.Add("nome 5");

            List<string> lista_telefones = new List<string>();
            lista_telefones.Add("1234");
            lista_telefones.Add("12345");
            lista_telefones.Add("123456");
            lista_telefones.Add("1234567");
            lista_telefones.Add("12345678");

            cl_GestorBD gestor = new cl_GestorBD("loja");
            DataTable dados = gestor.PREPARAR_DATATABLE("SELECT * FROM clientes WHERE id_cliente = -1");

            int id_temp = gestor.ID_DISPONIVEL("clientes", "id_cliente");

            //percorrer todos os nomes e adicionar à datatable

            for (int i  = 0; i < lista_nomes.Count; i++)
            {
                DataRow nova_linha = dados.NewRow();
                nova_linha["id_cliente"] = id_temp;
                nova_linha["nome"] = lista_nomes[i];
                nova_linha["telefone"] = lista_telefones[i];
                dados.Rows.Add(nova_linha);
                id_temp++;
            }

            gestor.GRAVAR_DATATABLE(dados);

            MessageBox.Show("Incluido listas");
        }

        private void btn_CompctBase_Click(object sender, EventArgs e)
        {
            //compactar a base de dados
            cl_GestorBD gestor = new cl_GestorBD("loja");
            if (gestor.Compactar_Base_Dados() == true)
            {
                MessageBox.Show("Base de Dados Compactada com sucesso.");
            }
            
        }
    }
}
