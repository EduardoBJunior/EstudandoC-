using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace EviarEmail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEviar_Click(object sender, EventArgs e)
        {
            //enviar email

            SmtpClient cliente = new SmtpClient();
            NetworkCredential credenciais = new NetworkCredential();


            //definir as configurações do cliente
            cliente.Host = "smtp.gmail.com";
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
            cliente.UseDefaultCredentials = false;

            // definir as credenciais de acesso
            credenciais.UserName = "metatecnologiatreinamento";
            credenciais.Password = "metaposto2019";
            // redenciais.Password = "aaaa";// cria o erro para trycat


            //define as credenciais
            cliente.Credentials = credenciais;

            //preparar a Mensagem a enviar
            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress("eduardobrandaojunior@gmail.com");
            mensagem.Subject = "Mensagem em HTML";
            mensagem.IsBodyHtml = true;
            mensagem.Body = "<strong> CUIDADO</strong>:  Sua conta de email esta sendo usada por uma aplicação externa.";
            mensagem.To.Add("eduardobrandaojunior@gmail.com");


            try
            {
                //envio da mensagem de e-mail
                cliente.Send(mensagem);
                MessageBox.Show("Mensagem Enviada Com sucesso");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Não foi possivel enviar a mensagem!");
                //escrever um arquivo com o texto de erro
                //+Environment.NewLine+Environment.NewLine +ex.Message
            }



        }

        private void btn_verificar_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text;

            bool resultado = true;

            //verificar o endereço de e-mail 
            Regex reg = new Regex(@"(\w+@[a-zA-Z]+?\.[a-zA-Z]{2,6})");

            if (!reg.IsMatch(email))
                resultado = false;

            //verifica se o e-mail tem 2 ou mais @
            int num_ats = 0;
            foreach (char c in email)
            {
                if (c == '@')
                {
                    num_ats++;
                }
            }
            if (num_ats != 1)
            {
                resultado = false;
            }

            //verificar se o email é correto
            if (!resultado)
            {
                MessageBox.Show("Email invalido.");
            }
        }

    }
}