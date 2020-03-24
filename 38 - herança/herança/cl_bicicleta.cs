using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herança
{
    class cl_bicicleta : cl_veiculo
    {  
        public void Pedalar()
        {

        }
        public override void Acelerar()
        {
            Console.WriteLine("A bicicleta Acelerou");
        }
    }
}
