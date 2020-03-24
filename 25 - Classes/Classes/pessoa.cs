using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{

    class pessoa
    {
        public string nome;
        public string apelido;

        public void IdentificarSe()
        {
            System.Windows.Forms.MessageBox.Show(ConstruirNome());

        }
        private string ConstruirNome()
        {
            string nome_completo = nome + " " + apelido;
            return nome_completo;
        }
        
    }
}
