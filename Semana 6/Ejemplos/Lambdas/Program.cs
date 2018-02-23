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

        static int[] ZipWith(int[] nums1, int[] nums2, Func<int,int,int> zipper){
            // ... //
            return null;
        }

        static int Reduce(int[] nums, int inicial, Func<int,int,int> reducer){
            // ... //
            return default(int);
        }

        /**
        Busca el valor mas grande en el arreglo "valores" utilizando
        la funcion "cmp" como criterio para comparar valores.
        La funcion "cmp" retorna true si el primer valor es mas
        grande que el segundo o false en caso contrario.
        */
        static int MaxBy(int[] valores, Func<int,int,bool> cmp){
            int comparacion = valores[0];

            for(int i = 0; i < valores.Length; i++){
                int num = valores[i];
                if(cmp(num, comparacion)){
                    comparacion = num;
                }
            }

            return comparacion;
        }

        static T GMaxBy<T>(T[] valores, Func<T,T,bool> cmp){
            T comparacion = valores[0];

            for(int i = 0; i < valores.Length; i++){
                T num = valores[i];
                if(cmp(num, comparacion)){
                    comparacion = num;
                }
            }

            return comparacion;
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
