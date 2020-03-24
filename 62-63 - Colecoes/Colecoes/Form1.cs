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

            //foreach (var item in Nomes)
            //{
            //    listBox1.Items.Add(item);
            //}

            //MessageBox.Show(Nomes[3]);
            //MessageBox.Show(Nomes.Count.ToString());

            //Nomes.RemoveAt(1);
            //foreach (var item in Nomes)
            //{
            //    listBox1.Items.Add(item);
            //}

            //if (Nomes.Contains("Brandão"))
            //{
            //    MessageBox.Show("Tem");
            //}else
            //{
            //    MessageBox.Show("Não tem");
            //}
            MessageBox.Show(Nomes.LastIndexOf("Aline meu amor").ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> lista_inteiros = new List<int>() { 10,20,30};
            foreach (var valor in lista_inteiros)
                listBox1.Items.Add(valor);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //gerencia a duplicação de valores em uma lista
            HashSet<string> lista_nome = new HashSet<string>()
            {
                "Eduardo","carlos","Aline", "Marcos"
            };
            if (!lista_nome.Add("Carlos"))
            {
                MessageBox.Show("Erro!");
            }
            foreach (string nome in lista_nome)
                listBox1.Items.Add(nome);
            
            //Apresenta a contagem da lista
            //MessageBox.Show(lista_nome.Count.ToString());


        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Dictionary<int, string> lista_valores;
            //lista_valores = new Dictionary<int, string>;

            //lista_valores.Add(10 ,"joão");
            //lista_valores.Add(115, "Antonio");

            //MessageBox.Show(lista_valores[0 ]);

            Dictionary<string, string> lista_valores;
            lista_valores = new Dictionary<string, string>();

            lista_valores.Add("button4","Dictionary");
            lista_valores.Add("button3","HashSet");
            lista_valores.Add("button2","List Inline");

            foreach (KeyValuePair<string,string> item in lista_valores)
            {
                listBox1.Items.Add(item.Key);
                listBox1.Items.Add(item.Value);
            }
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
