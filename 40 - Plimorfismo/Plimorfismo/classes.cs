using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plimorfismo
{
    abstract class forma_goemetrica
    {
        int _largura;
        int _altura;
        public int Largura
        {
            get { return _largura; }
            set { _largura = value; }
        }

        public int Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }

        public void Apresentar()
        {
            Console.WriteLine("Este Método perntence a classe base.");
        }
        //TERA DE SER IMPLENTANDO EM TODAS AS CLASSES DERIVADAS
        public abstract void Desenhar();

        public virtual void Desenhar_Outro()
        {
            Console.WriteLine("Metodo virtual da classe base.");
        }
    }

    class rectangulo : forma_goemetrica
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhar um Retangulo com as dimenções : " + Largura +" x "+ Altura);
        }
    }
    class triangulo : forma_goemetrica
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhar um Triangulo com as Dimentções : "+Largura + " x " + Altura);
        }
        public override void Desenhar_Outro()
        {
            Console.WriteLine("Este é um metodo virtual substituido da classe base");
        }
    }
    class circunferencia : forma_goemetrica
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhar uma Circinferencia com as dimenções de :"+ Largura+" x "+ Altura);
        }
    }
}
        

