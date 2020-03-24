using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datahora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Mostra a data e hora inteira
            //label1.Text = DateTime.Now.ToString();

            // mostra apenas  a data
            //label1.Text = DateTime.Now.ToShortDateString();

            // mostra apenas  a hora
            //label1.Text = DateTime.Now.ToShortTimeString();

            // definir formato da data
            //label1.Text = DateTime.Now.ToString("yyyy-MM-dd");


            //definir uma data que não é a atual (now ou today)

            //DateTime data = new DateTime(1992, 10, 12);
            //label1.Text = data.DayOfYear.ToString();

            //altera a cultura para portugues
            var culture = new CultureInfo("pt-BR");
            
            // coleta os dados da tela e convert para text (int.parse é melhor devido o alocamento de memoria utilizando a memoria steak e não o gabge colector)
            int dia = int.Parse(textBox1.Text);
            int mes = int.Parse(textBox2.Text);
            int ano = Convert.ToInt32(textBox3.Text);


   
            // cria um objeto do tipo DateTime
            DateTime DiaNascAno = new DateTime(ano,mes,dia);

            // apresenta o numero do dia do ano 
            //label1.Text = DiaNascAno.DayOfYear.ToString();

            //
            label1.Text = "o dia da semana que nasci é : "+ culture.DateTimeFormat.GetDayName(DiaNascAno.DayOfWeek);
            
        }
    }
}
