
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorOverloading
{
    class teste
    {
        string _nome;
        int _idade;
        public teste(string nome,int idade)
        {
            _nome = nome;
            _idade = idade;
             
        }
        //metodo  padrão
        public void Aprensentar()
        {
            System.Windows.Forms.MessageBox.Show(_nome + " > "+_idade);
        }
        //metodod Overloading 
        public void Apresentar(string separador)
        {
            System.Windows.Forms.MessageBox.Show( _nome +separador+_idade);

        }
        public void Apresentar(int idade)
        {
            
        }
    }
}
