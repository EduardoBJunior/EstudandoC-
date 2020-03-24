using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseEstatica
{
    public static class estatica
    {
        //classe etatica é acessada em qualquer lugar da programação
        //não precisa ser instanciada (criar um objeto)

            //todo field (prpriedade) da classe statica
        public static string Nome;
        // esta prorpiedade podera ser alterada de qualquer local do codido, ficando com o novo valor permanente
        public static string NomePrograma = "Aplicação d Teste";
        public static void ApresentarNome()
        {
            Console.WriteLine(Nome);
        }
    }
}
