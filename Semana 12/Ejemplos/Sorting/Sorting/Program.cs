using System;
public class Program
{
    public static int[] BubbleSort(int[] valores)
    {
        int[] resultado = new int[valores.Length];

        for(int i = 0; i < valores.Length; i++)
        {
            int actual = valores[i];
            for(int j = 0; j < valores.Length; j++)
            {
                int otro = valores[j];

                if(actual < otro)
                {
                    resultado[i] = otro;
                }
            }
        }

        return resultado;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
    }
}
