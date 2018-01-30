using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Coleccion c1 = new Coleccion();
            IColeccion c2 = Program.Reversa(c1);
        }

        static IColeccion Reversa(IColeccion coleccion){

            coleccion = coleccion.Duplicar();
            
            int[] tmp = new int[coleccion.Size];
            for(int i = 0; i < coleccion.Size; i++){
                tmp[coleccion.Size - i - 1] = coleccion.Get(i);
            }

            for(int i = 0; i < coleccion.Size; i++){
                coleccion.Set(i, tmp[i]);
            }

            return coleccion;
        }
    }
}
