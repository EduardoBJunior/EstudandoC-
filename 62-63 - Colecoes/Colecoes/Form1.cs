using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colecoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //array
            //antigo qse não se usa mais 
            //string[] nomes;
            //nomes = new string[5];

            //nomes[0] = "Eduardo";
            //nomes[1] = "Brandão";
            //nomes[2] = "Junior";
            //nomes[3] = "ALine";
            //nomes[4] = "Campos";

            //listBox1.Items.AddRange(nomes);

            //coleções - do tipo LIST

            List<string> Nomes = new List<string>();

            Nomes.Add("Eduardo");
            Nomes.Add("junior");
            Nomes.Add("Aline");
            Nomes.Add("Campos");
            Nomes.Add("Aline meu amor");
            Nomes.Add("Aline meu amor");
            Nomes.Add("Aline meu amor");
            Nomes.Add("Aline meu amor");
            Nomes.Add("Aline meu amor");

            //Adiciona todos os intes na listbox pelo Foreach
            //foreach (var item in Nomes)
            //{
            //    listBox1.Items.Add(item);
            //}

            //mostra um nome da listagem
            //MessageBox.Show(Nomes[3]);

            //mostra a quantidade de item na lista
            //MessageBox.Show(Nomes.Count.ToString());

            //remove um item da lista
            //Nomes.Remove("Aline meu Amor")

            // remove o item na posição declarada
            //Nomes.RemoveAt(1);

            // conteis busta nos itens se existe a declaração
            //if (Nomes.Contains("Brandão"))
            //{
            //    MessageBox.Show("Tem");
            //}else
            //{
            //    MessageBox.Show("Não tem");
            //}

            //foreach (var item in Nomes)
            //{
            //    listBox1.Items.Add(item);
            //}


            //mostra o indice  da ultima varivel informada na lista
            MessageBox.Show(Nomes.LastIndexOf("Aline meu amor").ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //cria a lista inline ja adicionando os itens dentro das chaves
            List<int> lista_inteiros = new List<int>() { 10,20,30};
            // foreach Adiciona os valores na listbox
            foreach (var valor in lista_inteiros)
                listBox1.Items.Add(valor);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //hashset - e uma listagem generica, adicionando as chaves fica como a in line
            //hashset não permite mostrar os resultados atraves do valor exemplo: mbx(lista_nome[3]);
            //gerencia a duplicação de valores em uma lista, ela não permite que seja iguais os valores 
            HashSet<string> lista_nome = new HashSet<string>()
            {
                "Eduardo","carlos","Aline", "Marcos"
            };
            //o add no hashset é boleano por isso podemos usar comoavaliação
            if (!lista_nome.Add("carlos"))
            {
                MessageBox.Show("Erro!");
            }
            //apresenta os valores do hashset na listbox
            foreach (string nome in lista_nome)
                listBox1.Items.Add(nome);
            
            //Apresenta a contagem da lista
            //MessageBox.Show(lista_nome.Count.ToString());


        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Dictionary obriga a definir dois tipo de valores TKey e o TValue
            //TKey é o indice
            //Tvalue é o valor

            //Dictionary<int, string> lista_valores;
            //lista_valores = new Dictionary<int, string>;

            //permite adicionar parametros repetidos;
            //lista_valores.Add(10 ,"joão");
            //lista_valores.Add(115, "Antonio");

            // como não existe o indeice 0 da erro 
            //MessageBox.Show(lista_valores[0]);

            Dictionary<string, string> lista_valores;
            lista_valores = new Dictionary<string, string>();

            lista_valores.Add("button4","Dictionary");
            lista_valores.Add("button3","HashSet");
            lista_valores.Add("button2","List Inline");

            //adiciona os valores
            foreach (KeyValuePair<string,string> item in lista_valores)
            {
                listBox1.Items.Add(item.Key);
                listBox1.Items.Add(item.Value);
            }

            //verifica se a coleção tem uma determinada chave
            if (lista_valores.ContainsKey("button3"))
            {
                MessageBox.Show("SIM!");
            }
            else
            {
                MessageBox.Show("Não!");
            }
        }
    }
}
