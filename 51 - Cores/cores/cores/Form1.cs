using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace cores
{
    public partial class Form1 : Form
    {
        Color cor = Color.Black;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             ARGB
             0= mais escuro 
             255 = mais claro
             A = alfa  dvai de 0 ate 255
             Red, 
             */
            //pictureBox1.BackColor = Color.FromArgb(0, 100, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //label1.Text = "0";
            //label2.Text = "0";
            //label3.Text = "0";
        }
        private void ApresentarCor()
        {

            cor = Color.FromArgb(trackBar1.Value,trackBar2.Value,trackBar3.Value);
            pictureBox1.BackColor = cor;
            lb_exemplo.Text = "RGB ( "+ trackBar1.Value + ";"
                                      + trackBar2.Value + ";"
                                      + trackBar3.Value + " )";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
            ApresentarCor();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label2.Text = trackBar2.Value.ToString();
            ApresentarCor();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label3.Text = trackBar3.Value.ToString();
            ApresentarCor();
        }
    }
}
