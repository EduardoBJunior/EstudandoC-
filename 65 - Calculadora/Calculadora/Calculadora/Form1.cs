using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            //fechar a aplicação
            Application.Exit();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            //executa o calculo da operação
            int parcela1;
            int parcela2;

            string tipo_operacao;
            string algoritimo = txtb_operacao.Text;
            int resultado =-111111111; //resultado final da operação

            //123+321 encontrar o sinal

            string sinais = "+-*/";
            int index = 0;
            foreach (char c in algoritimo)
            {
                foreach (char s in sinais)
                {
                    if (c==s)
                    {
                        //define os 3 elementos da operacao
                        //parcela1
                        parcela1 = int.Parse(algoritimo.Substring(0, index));
                        //sinal
                        tipo_operacao = c.ToString();
                        //parcela2
                        parcela2 = int.Parse(algoritimo.Substring(index + 1));

                        //analisa a operação que será realizada
                        switch (tipo_operacao)
                        {
                            case "+":
                                resultado = parcela1 + parcela2;
                                break;
                            case "-":
                                resultado = parcela1 - parcela2;
                                break;
                            case "*":
                                resultado = parcela1 * parcela2;
                                break;
                            case "/":
                                resultado = parcela1 / parcela2;
                                break;
                            default:
                                break;
                        }
                        break;
                    }
                }
                //analisa resultado
                if (resultado!= -111111111)
                {
                    
                    break; 
                }
                index++;
            }
            //apresentação do resultado final 
            if (resultado == -111111111)
            {
                MessageBox.Show("Algoritimo digitado esta incorreto, tente novamente!");
            }
            else
            {
                MessageBox.Show(algoritimo + '=' + resultado.ToString());
            }
                //limpa o algoritimo
                txtb_operacao.Text = "";
                txtb_operacao.Focus();
              
                


        }

        private void txtb_operacao_KeyDown(object sender, KeyEventArgs e)
        {
            
            //ao precinar enter 
            if (txtb_operacao.Text == "") return;

            //analisa se o botão enter foi precionado
            if (e.KeyCode ==Keys.Return)
            {
                e.SuppressKeyPress = true;
                btn_calcular_Click(btn_calcular, EventArgs.Empty);


            }
            else if (e.KeyCode ==Keys.Escape)
            {
                txtb_operacao.Text = "";
                txtb_operacao.Focus();
            }
            
        }
    }
}
