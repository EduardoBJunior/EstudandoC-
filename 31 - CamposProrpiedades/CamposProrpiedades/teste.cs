using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamposProrpiedades
{
    class teste
    {
        //definicao de um campo
        // para definir campos de uma classe deve aplicar  o underscore "_"
        string _nome;
        int _idade;

        //definicao de uma propriedade
        public string Nome{get;set;}


        public void Apresentar()
        {
            System.Windows.Forms.MessageBox.Show(_nome );
        }
    }
}
