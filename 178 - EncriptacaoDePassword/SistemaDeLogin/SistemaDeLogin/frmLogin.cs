using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeLogin
{
    public partial class frmLogin : Form
    {

        // dados do utilizador 
        string utilizador = "manuel";
        string senha = "1234" ;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            //Fechar a aplicação
            Application.Exit();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            //Verifica se o login é correto
            bool entrar = true;

            //verifica se  houve falha de introdção de dados
            if (txtUsuario.Text != utilizador && txtSenha.Text != senha)
            {
                MessageBox.Show("Dadaos de login inválidos");
                entrar = false;
            }



            //se o login é correto, abre o menu principal
            if (entrar)
            {
                this.Hide();
                frmMenu f = new frmMenu();
                f.ShowDialog();

            }


        }

        private void check_Visualizar_password_CheckedChanged(object sender, EventArgs e)
        {
            // visualiza ou esconde o texto do pasword

            if (check_Visualizar_password.Checked)
            {
                //mostra o password
                txtSenha.PasswordChar = '\0';

            }
            else
            {
                //esconder o password
                txtSenha.PasswordChar = '*';
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
