using System;
using System.Linq;

namespace Lambdas
{
    class Program
    {

        static void Ejemplo_Func(){
        }

        static void Ejemplo_Action(){
            Func<int,int> suma = (x) => {return x+x;}
        }

        static void Main(string[] args)
        {
        }
    }
}
