using System;
using System.Linq;

namespace Lambdas
{
    public delegate void ForEachArgs(int what);

    class Program
    {

        static T Buscar<T>(T[] numeros, Func<T,bool> query){

            for(int i = 0; i < numeros.Length; i++){
                if(query(numeros[i])){
                    return numeros[i];
                }
            }

            return default(T);
        }

        static int MaxBy(int[] valores, Func<int,int,bool> cmp){

        }

        static void Ejemplo_Buscar(){
            int[] numeros = new int[]{1,4,2,6,-42,7,8,4};

            Program.Buscar(numeros, valor => valor == 7);
            Program.Buscar(numeros, valor => valor % 3 == 0);

            Program.MaxBy(numeros, (x,y) => x > y);
            Program.MaxBy(numeros, (x,y) => Math.Abs(x) > Math.Abs(y));
        }

        static void Ejemplo_Func(){
            Func<int,int,int> sumar = (x,y) => x + y;
            int resultado = sumar(1,2);

            Func<double[], double> promedio = numeros => {
                double respuesta = 0;

                for(int i = 0; i < numeros.Length; i++){
                    respuesta += numeros[i] / numeros.Length;
                }
                
                return respuesta;
            };
        }

        static void Ejemplo_Action(){

            Action<int> imprimir = valor => {
                Console.WriteLine($"El numero es #{valor}");
            };

            imprimir(50);

            imprimir = valor => {
                Console.WriteLine($"El numero es #{valor + 1}");
            };

            imprimir(50);

            Action<string, string> juntar = (valor1, valor2) => Console.WriteLine(valor1 + valor2);

            Action<string> imprimir2 = Console.WriteLine;

            imprimir2("hola");
        }

        static void Main(string[] args)
        {

        }
    }
}
