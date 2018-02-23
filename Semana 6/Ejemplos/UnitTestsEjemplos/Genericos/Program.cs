using System;

namespace Genericos
{

    public class Tupla<T1,T2>{

        public Tupla(T1 t1, T2 t2){
            this.Primero = t1;
            this.Segundo = t2;
        }
        public T1 Primero {get;}
         
        public T2 Segundo {get;}
    }

    public class Program
    {
        public static Tupla<T1,T2>[] Zip<T1,T2>(T1[] arr1, T2[] arr2){
            return null;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
