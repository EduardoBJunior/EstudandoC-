using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace linq
{
    //=====================================================
    // projeto para testar instruções LINQ em C#
    //=====================================================
    public partial class frmLINQ : Form
    {
        List<int> lista_numeros;
        List<string> lista_nomes;
        Dictionary<string, double> lista_produtos;
        List<cl_alunos> lista_alunos;
        DataTable dados;

        //=================================================
        public frmLINQ()
        {
            InitializeComponent();

            //carrega os dados das coleções
            cl_colecoes colecoes = new cl_colecoes();
            lista_numeros = colecoes.lista_numeros;
            lista_nomes = colecoes.lista_nomes;
            lista_produtos = colecoes.lista_produtos;
            lista_alunos = colecoes.lista_alunos;
            dados = colecoes.dados;
        }

        //=================================================
        private void Form1_Load(object sender, EventArgs e)
        {
            //apresenta o número de registos em cada coleção
            lista.Items.Add("lista_numeros = " + lista_numeros.Count + " números.");
            lista.Items.Add("lista_nomes = " + lista_nomes.Count + " nomes.");
            lista.Items.Add("lista_produtos = " + lista_produtos.Count + " produtos.");
            lista.Items.Add("lista_alunos = " + lista_alunos.Count + " alunos.");
            lista.Items.Add("dados (DataTable) = " + dados.Rows.Count + " linhas.");
        }

        //=================================================
        private void cmd_sair_Click(object sender, EventArgs e)
        {
            //fecha a aplicação
            Application.Exit();
        }

        //=================================================
        private void cmd_executar_Click(object sender, EventArgs e)
        {
            //execução dos testes
            lista.Items.Clear();
            label_resultado.Text = "";

            //operador de restrição 
            //------------------------------------------------------------------------
            // USAR O LINK PARA VERIFICAR VALORES QUE SÃO INFERIRORES A 20
            //var numeros = from num in lista_numeros where num <= 10 || num >=20 select num;
            //foreach (int n in numeros)
            //    lista.Items.Add(n.ToString());

            // 
            //------------------------------------------------------------------------
            //uso de linq na lista de nome
            //var nomes = from nome in lista_nomes where nome.Contains("Ribeiro") || nome.Contains("Ana") select nome;

            //// lista de nomes sem nome 
            //foreach (string n in nomes)
            //    lista.Items.Add(n);

            //------------------------------------------------------------------------
            //lista de Produtos  - a lista é um Dictonary com linq
            //var resultados = from item in lista_produtos where item.Key.StartsWith("M") select item;

            //outra forma de escrever link - Função lambda
            //var resultados = lista_produtos.Where(produto => produto.Key.StartsWith("M"));

            //foreach(KeyValuePair<string,double> resultado in resultados)
            //  lista.Items.Add(resultado);
            //lista.Items.Add(resultado.Key); mostra pela letra
            //lista.Items.Add(resultado.Value); mostra apenas o valor

            //------------------------------------------------------------------------
            //lista  dados de uma classe com linq
            //var resultados = from aluno in lista_alunos select "O Aluno nº " + aluno.numero + " é " + aluno.nome;

            //foreach(string n in resultados)
            //    lista.Items.Add(n);

            //------------------------------------------------------------------------
            //usando link com array de indices para apresentar dados 
            //int[] indices = new int[] { 3, 2, 1 };

            //var resultados = from indice in indices select lista_nomes[indice];

            ////foreach (string nome in lista_nomes)
            ////    lista.Items.Add(nome);
            //foreach (string nome in resultados)
            //    lista.Items.Add(nome);

            //------------------------------------------------------------------------
            //definir no select nomes de variaveis

            //var turma = from a in lista_alunos where a.nome.Contains("a") select new {num = a.numero, nom = a.nome, sex = a.sexo };

            //foreach (var aluno in turma)
            //    lista.Items.Add(aluno.nom );
            //------------------------------------------------------------------------
            // linq devolver numeros de forma ordenada

            //var numeros = from numero in lista_numeros orderby numero select numero;
            //foreach (int numero in numeros)
            //{
            //    lista.Items.Add(numero);
            //}

            //var turma = from aluno in lista_alunos  orderby aluno.nome descending select aluno;

            //foreach (cl_alunos aluno in turma)
            //    lista.Items.Add(aluno.nome +"("+ aluno.nome.Length+")");
            //------------------------------------------------------------------------
            //usando a expressão lambda produtos

            //var produtos = from produto in lista_produtos
            //               orderby produto.Key descending
            //               select produto;
            //lambda
            //var produtos = lista_produtos.OrderByDescending(i => i.Key);

            //foreach (KeyValuePair<string,double> produto in produtos)
            //{
            //    lista.Items.Add(produto.Key);
            //}
            //------------------------------------------------------------------------
            //Cout com versão lambda
            label_resultado.Text = lista_numeros.Count().ToString();



            //var valores = from l in lista_numeros where l < 20 select l;
            //foreach (var valor in valores)
            //    lista.Items.Add(valor);

            //var contagem = (from l in lista_numeros where l < 20 select l).Count();

            //label_resultado.Text = contagem.ToString();
            //------------------------------------------------------------------------
            //Sum com lambda
            
            label_resultado.Text = "O Resultado da somatoria de todos ("+lista_numeros.Count()+") os numeros é : "+lista_numeros.Sum().ToString();
           
            foreach(int num in lista_numeros)
            {
                lista.Items.Add(num);
            }

            //lambda 
            label_resultado.Text = "somatorio: "+ lista_numeros.Where(i => i < 20).Sum();
            label_resultado.Text = "Min : " + lista_numeros.Min();
            label_resultado.Text = "Max : " + lista_numeros.Max();

            //usando Nomes 
            label_resultado.Text = "O Nome mais curto é :" +lista_nomes.Max();

            foreach (string nome in lista_nomes)
                lista.Items.Add(nome + "total de caracter : "+ nome.Length);

            int resultado = lista_nomes.Min(i => i.Length);

                label_resultado.Text = "O numero de letras mais pequeno de um nome na lista: " + resultado;

            //media de valores

            double media = lista_numeros.Average();
            label_resultado.Text = media.ToString();

            //operadores de elemento first,first order default , elemente ex

            //
            List<int> numeros = new List<int>() { };

            //First
            //label_resultado.Text = numeros.First().ToString();
            //label_resultado.Text = numeros[0].ToString(); // esse da erro quando a lista esta vazia

            //Valor por padrão
            label_resultado.Text = numeros.FirstOrDefault().ToString();

            label_resultado.Text = lista_nomes.FirstOrDefault().ToString();
            label_resultado.Text = lista_nomes.ElementAt(2); //

            //operação lambda
            label_resultado.Text = lista_nomes.Where(i => i.Contains("Silva")).ElementAt(1); //ElementAt = vai trazer o segundo elemnteo da conleção filtrada por "Silva"

            // saber quantos Alunos são do sexo feminio
            int numero_alunas = (from aluno in lista_alunos where aluno.sexo == "feminino" select aluno).Count();
            //label_resultado.Text = "Esta Turma tem " + numero_alunas + " alunas.";
            label_resultado.Text = string.Format("Esta Turma tem {0} alunas", numero_alunas);
        }
    }
}

