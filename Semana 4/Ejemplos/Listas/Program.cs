using System;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            IList<string> lista = new LinkedList<string>("hola");

            IList<int> lista2 = new LinkedList<int>(42);

            IList<string> lista3 = new LinkedList<string>("mundo");

            IList<string> resultado = Helpers.Concat<string>(lista, lista3);
            // resultado.Push(new object()); //Fallo!
            resultado.Push("test"); // Si sirve
        }
    }
}
