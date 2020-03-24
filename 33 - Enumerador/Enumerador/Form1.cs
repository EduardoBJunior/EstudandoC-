using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enumerador
{
    public partial class Form1 : Form
    {
        Teste jogador;
        public Form1()
        {
            InitializeComponent();
            jogador = new Teste();
        }

        private void btn_cima_Click(object sender, EventArgs e)
        {
            jogador.Mover(Teste.Movimentos.Cima);
        }

        private void btn_direita_Click(object sender, EventArgs e)
        {
            jogador.Mover(Teste.Movimentos.Direita);
        }

        private void btn_esquerda_Click(object sender, EventArgs e)
        {
            jogador.Mover(Teste.Movimentos.Esquerdo);
        }

        private void btn_baixo_Click(object sender, EventArgs e)
        {
            jogador.Mover(Teste.Movimentos.Esquerdo);
        }
    }
}
