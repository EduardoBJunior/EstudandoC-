using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnu_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            //adicionar  opção ao combo menu 
            mnu_combo_1.Items.Add("Valor 1");
            mnu_combo_1.Items.Add("Valor 2");
            mnu_combo_1.Items.Add("Valor 3");
            mnu_combo_1.Items.Add("Valor 4");
            mnu_combo_1.Items.Add("Valor 5");
        }

        private void mnu_open_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OPEN!");
        }

        private void mnu_combo_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mnu_combo_1.Text =="Valor 1")
            {
                MessageBox.Show("ok");
            }
        }
    }
}
