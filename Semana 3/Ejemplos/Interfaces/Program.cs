using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Coleccion c1 = new Coleccion();
            Program.Reversa(c1);
        }

        static void Reversa(IColeccion coleccion){

            int[] tmp = new int[coleccion.Size];
            for(int i = 0; i < coleccion.Size; i++){
                tmp[coleccion.Size - i - 1] = coleccion.Get(i);
            }

            for(int i = 0; i < coleccion.Size; i++){
                coleccion.Set(i, tmp[i]);
            }
        }
    }
}
