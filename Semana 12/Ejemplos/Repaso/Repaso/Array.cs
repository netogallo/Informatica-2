using System;
public class Array
{
    public static void Arrays()
    {
        int[] arreglo = new int[10];

        int[] arreglo2 = new int[]{1,2,3,4,5,5,6,7,3,8};

        int v1 = arreglo[3];

        int n = 0;

        while(n < 10)
        {
            Console.WriteLine(arreglo2[n]);
            n++;
        }
    }
}