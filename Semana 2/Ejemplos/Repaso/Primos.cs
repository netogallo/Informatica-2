public static class Primos{
    // Elisa elisammg
    public static bool Ejemplo2(int n);

    // Adrian gaitan171299
    public static bool Ejemplo3(int n);

    // Javier, jjalvarez
    public static int[] Ejemplo(int n)
    {
        int i, num = 2, cont = 0;
        int[] numeros = new int[n];
        while (cont < n)
        {
            i = 2;
            while (i <= num)
            {
                if (i == num)
                {
                    numeros[cont] = num;
                    cont = cont + 1;
                    break;
                }
                else
                {
                    if (num % i == 0)
                    {
                        i = num;
                        break;
                    }
                }
                i = i + 1;
            }
            num = num + 1;
        }
        return numeros;
    }
}