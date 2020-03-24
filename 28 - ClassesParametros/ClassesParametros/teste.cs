using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesParametros
{
    class teste
    {
        public int Acressentar(int x,int v =20) {
            v = v + x;
            return v;
        }
        public void Diminuir (int valor)
        {
            valor -= 5;
        }
    }
}
