using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
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

            //operador de restrição 129
            //------------------------------------------------------------------------
            // USAR O LINK PARA VERIFICAR VALORES QUE SÃO INFERIRORES A 20
            //&& = and no Linq
            //|| = ou no linq

            //var numeros = from num in lista_numeros where num <= 10 || num >=20 select num;
            //foreach (int n in numeros)
            //    lista.Items.Add(n.ToString());

            // 
            //------------------------------------------------------------------------

            //uso de linq na lista de nome verificando se no nome contem um valor especifico

            //var nomes = from nome in lista_nomes where nome.Contains("Ribeiro") || nome.Contains("Ana") select nome;

            //// lista de nomes sem nome 
            //foreach (string n in nomes)
            //    lista.Items.Add(n);

            //------------------------------------------------------------------------
            //lista de Produtos<string, double> - a lista é um Dictonary com linq
            // Dictonary tem 2 valores  chamasse de um key value per

            //buscando os produtos que a chave inicia com a letra M
            //var resultados = from item in lista_produtos where item.Key.StartsWith("M") select item;

            //outra forma de escrever link - Função lambda
            //var resultados = lista_produtos.Where(produto => produto.Key.StartsWith("M"));


            //foreach(KeyValuePair<string,double> resultado in resultados)



            //outra forma de escrever link - Função lambda
            //var resultados = lista_produtos.Where(produto => produto.Key.StartsWith("M"));


            //lista.Items.Add(resultado);
            //lista.Items.Add(resultado.Key); mostra pela letra
            //lista.Items.Add(resultado.Value); mostra apenas o valor

            //------------------------------------------------------------------------
            //lista  dados de uma classe com linq 130

            //var resultados = from aluno in lista_alunos select "O Aluno nº " + aluno.numero + " é " + aluno.nome;

            //foreach(string n in resultados)
            //    lista.Items.Add(n);

            //------------------------------------------------------------------------
            //usando link com array de indices para apresentar dados 
            //int[] indices = new int[] { 3, 2, 1 };

            //var resultados = from indice in indices select lista_nomes[indice];

            //foreach (string nome in lista_nomes) //apresenta todos os nomes da lista
            //    lista.Items.Add(nome);

            //foreach (string nome in resultados)//apresenta os dados utilizando o indece
            //    lista.Items.Add(nome);

            //------------------------------------------------------------------------
            //definir no select nomes de variaveis

            //var turma = from a in lista_alunos
            //where a.nome.Contains("a")  // para utilizar o whare mesmo sendo criado um nv obj so é possivel utilizar o obj original
            //select new {num = a.numero, nom = a.nome, sex = a.sexo }; //entre chaves esta sendo criado um novo obj onde esta sendo formatado a saida dos valores

            //foreach (var aluno in turma)
            //    lista.Items.Add(aluno.nom );
            //------------------------------------------------------------------------
            // linq devolver numeros de forma ordenada 131

            //var numeros = from numero in lista_numeros orderby numero select numero;
            //foreach (int numero in numeros)
            //{
            //    lista.Items.Add(numero);
            //}

            //var turma = from aluno in lista_alunos /*posso usar o where*/ orderby aluno.nome descending select aluno;

            //foreach (cl_alunos aluno in turma)
            //    lista.Items.Add(aluno.nome +"("+ aluno.nome.Length+")");
            //------------------------------------------------------------------------
            //Produtos - dictonary<string, double>

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
            //Cout com versão lambda - 131

            //label_resultado.Text = lista_numeros.Count().ToString();



            //var valores = from l in lista_numeros where l < 20 select l;
            //foreach (var valor in valores)
            //    lista.Items.Add(valor);

            //var contagem = (from l in lista_numeros where l < 20 select l).Count();

            //label_resultado.Text = contagem.ToString();
            //------------------------------------------------------------------------
            //Sum com lambda 131

            //label_resultado.Text = "O Resultado da somatoria de todos ("+lista_numeros.Count()+") os numeros é : "+lista_numeros.Sum().ToString();

            //foreach(int num in lista_numeros)
            //{
            //    lista.Items.Add(num);
            //}

            ////lambda 
            //label_resultado.Text = "somatorio: "+ lista_numeros.Where(i => i < 20).Sum();
            //label_resultado.Text = "Min : " + lista_numeros.Min();
            //label_resultado.Text = "Max : " + lista_numeros.Max();
            //------------------------------------------------------------------------------------
            //usando sum/min/max com  Nomes 131
            //label_resultado.Text = "O Nome mais curto é :" +lista_nomes.Max();

            //foreach (string nome in lista_nomes)
            //    lista.Items.Add(nome + "total de caracter : "+ nome.Length);

            //int resultado = lista_nomes.Min(i => i.Length);

            //    label_resultado.Text = "O numero de letras mais pequeno de um nome na lista: " + resultado;
            //---------------------------------------------------------------------
            //media de valores - 131

            //double media = lista_numeros.Average();
            //label_resultado.Text = media.ToString();
            //----------------------------------------------------------------------------
            //132
            //operadores de elemento first,first order default , elemente ex

            //
            //List<int> numeros = new List<int>() { };

            //First -busca o primeiro valor 
            //label_resultado.Text = numeros.First().ToString();
            //label_resultado.Text = numeros[0].ToString(); // esse da erro quando a lista esta vazia

            //Valor por padrão 
            //- quando náo existir valor na lista utilizar essa opçao para nao dar crash
            //label_resultado.Text = numeros.FirstOrDefault().ToString();

            //label_resultado.Text = lista_nomes.FirstOrDefault().ToString();// apresenta o valor por defaut
            //label_resultado.Text = lista_nomes.ElementAt(2); //

            ////operação lambda
            //label_resultado.Text = lista_nomes.Where(i => i.Contains("Silva")).ElementAt(1); //ElementAt = vai trazer o segundo elemnteo da conleção filtrada por "Silva"
            //------------------------------------------------------------------------------------
            //134
            //// saber quantos Alunos são do sexo feminio sem lambda
            ///---------------------------------------------------------------------------------------------

            //int numero_alunas = (from aluno in lista_alunos where aluno.sexo == "feminino" select aluno).Count();

            ////label_resultado.Text = "Esta Turma tem " + numero_alunas + " alunas.";

            //label_resultado.Text = string.Format("Esta Turma tem {0} alunas", numero_alunas);//outra forma de concatenar

            //--------------------------------------------------------------------------------------
            //saber os resultados do Exame de Matematica sem lambda

            //var notas_matematicas = from nota in lista_alunos select nota.EXAMES[0];

            //foreach (var nota in notas_matematicas)
            //{
            //    lista.Items.Add("Nota de Matematica = "+nota.nota_exame);

            //----------------------------------------------------------------------------------

            //numero de alunas (lambda)

            //int numero_alunas = lista_alunos.Where(i => i.sexo == "feminino").Count();
            //label_resultado.Text = "Numero alunas: " + numero_alunas;

            //resultado do exame de matemática(lambda)
            //var notas = lista_alunos.Select(i => i.EXAMES[0]);

            //foreach(var nota in notas)
            //{
            //    lista.Items.Add(nota.nota_exame);
            //}
            //-----------------------------------

            //quantos alunos tiveram nota positiva no exame de matemática

            //int positivas_matematica = lista_alunos.Where(i => i.EXAMES[0].nota_exame >=10).Count();
            //label_resultado.Text = string.Format("Na turma, {0} alunos tiveram positiva a Matemática.", positivas_matematica);

            //alunos tiveram positiva no exame de matemática - linq

            //int positivas_matematica = (from aluno in lista_alunos where aluno.EXAMES[0].nota_exame>= 10 select aluno).Count();

            //========================================================================================
            //135

            //medias das notas de exame matematica
            //normal
            //double media_matematica = (from aluno in lista_alunos select aluno.EXAMES[0].nota_exame).Average();

            //lambda
            // double media_matematica = lista_alunos.Average(i => i.EXAMES[0].nota_exame);

            //label_resultado.Text = string.Format("A média dos exames de Matemática foi {0} valores",media_matematica);
            //-----------------------------------------------------------------------
            //var notas_biologia = lista_alunos.Select(i => i.EXAMES[2].nota_exame);
            //foreach (var nota in notas_biologia)
            //{
            //    lista.Items.Add(nota);
            //}
            ///-----------------------------------------------------------------------
            ///
            //Média das positivas de biologia 
            //buscar e calcular as medias em uma consulta do linq

            //double media_biologia = lista_alunos.Where(i => i.EXAMES[2].nota_exame >= 10).Average(i => i.EXAMES[2].nota_exame);

            //label_resultado.Text = string.Format("A media das notas positivas de Biologia é {0} valores.", media_biologia);

            //=================================================================================
            //136

            //var notas = from aluno in lista_alunos
            //            select new
            //            {
            //                nome = aluno.nome,
            //                media = (aluno.EXAMES[0].nota_exame +
            //                         aluno.EXAMES[1].nota_exame +
            //                         aluno.EXAMES[2].nota_exame +
            //                         aluno.EXAMES[3].nota_exame) / 4
            //            };

            //foreach (var nota in notas)
            //{
            //    lista.Items.Add(nota. nome +" - "+nota.media);
            //}

            //----------------------------------------------------------------
            //Listagem de notas de Matemática por ordem decrescente

            // primeiro separa as notas de matematica e depois ordenar 

            //var alunos = (from aluno in lista_alunos
            //              select new
            //              {
            //                  nome = aluno.nome,
            //                  nota_matematica = aluno.EXAMES[0].nota_exame
            //              }
            //             ).OrderByDescending(i => i.nota_matematica);

            //foreach (var aluno in alunos)
            //{
            //    lista.Items.Add(aluno.nome +" - "+aluno.nota_matematica);
            //}
            //----------------------------------------------------------------
            //Qual é o melhor aluno no geral - aluno que tem o conjuto de notas em geral onde o somatorio das 4 notas e verifica se esse valor  é o maior 

            //var alunos = (from aluno in lista_alunos
            //             select new
            //             {
            //                 nome = aluno.nome,
            //                 total_notas = aluno.EXAMES.Select(i => i.nota_exame).Sum()
            //             }).OrderByDescending(i => i.total_notas);

            //foreach (var aluno in alunos)
            //{
            //    lista.Items.Add(string.Format("{0} tem um total de {1} valores.",aluno.nome,aluno.total_notas));
            //}

            //================================================================================
            //137

            // DataTable
            //foreach (DataRow linha in dados.Rows)
            //{
            //    lista.Items.Add(string.Format("id_cliente = {0} | nome_cliente = {1} | cidade = {2} | num. encomendas = {3}", linha["id_cliente"].ToString(), linha["nome_cliente"].ToString(), linha["cidade"].ToString(), linha["numero_encomendas"].ToString()));
            //}

            //Lista apenas os nomes dos clientes

            //var clientes = from cliente in dados.AsEnumerable() select cliente["nome_cliente"].ToString();

            //foreach (var cliente in clientes)
            //{
            //    lista.Items.Add(cliente);
            //}

            ///selecionar de outra foram de ordem alfabatica
            //var clientes = (from cliente in dados.AsEnumerable() select cliente.Field<string>("nome_cliente")).OrderBy(i => i);

            //foreach(var cliente in clientes)
            //{
            //    lista.Items.Add(cliente);

            //}

            //outra forma de ordernar a consulta em ordem alfabeticas

            //var clientes = (from cliente in dados.AsEnumerable() select new { nome = cliente.Field<string>("nome_cliente") }).OrderBy(i => i.nome);

            //foreach (var cliente in clientes)
            //{
            //    lista.Items.Add(cliente.nome);
            //}
            //

            // Listagem de cliente que possui o maior numero de encomentdas

            //var clientes = (from cliente in dados.AsEnumerable()
            //                select new
            //                {
            //                    nome = cliente["nome_cliente"].ToString(),
            //                    numero_encomendas = (int)cliente["numero_encomendas"]
            //                }).OrderByDescending(i => i.numero_encomendas);

            //foreach(var cliente in clientes)
            //{
            //    lista.Items.Add(string.Format("O cliente {0} tem {1} encomendas no total.", cliente.nome, cliente.numero_encomendas)); 
            //}

            var clientes = from cliente in dados.AsEnumerable() // as enumerable tem que realzar a aplicação de asenumerable
                           where cliente.Field<string>("cidade") == "Rio de Janeiro"
                           select new
                           {
                               nome = cliente["nome_cliente"].ToString(),// quando usar data teble tem que usar isso
                               cidade = cliente.Field<string>("cidade")// ou isso 
                           };
            foreach (var cliente in clientes)
            {
                lista.Items.Add(cliente.nome + "- " + cliente.cidade);
            }

            // pesquisar por 101 linqs



        }
    }
}

