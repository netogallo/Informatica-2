using System.Linq;

public class BinaryTree : IBinTree{
    public int Valor {get; set;}

    public IBinTree Derecho {get;}

    public IBinTree Izquierdo {get;}

    public BinaryTree(int valor, IBinTree derecho, IBinTree izquierdo){
        this.Valor = valor;
        this.Derecho = derecho;
        this.Izquierdo = izquierdo;
    }

    public BinaryTree(int valor){
        this.Valor = valor;
    }

    public override string ToString(){
        string derecho = this.Derecho == null ? string.Empty : this.Derecho.ToString();
        string izquierdo = this.Izquierdo == null ? string.Empty : this.Izquierdo.ToString();
        return $"{this.Valor} \n\t {derecho} \n\t {izquierdo}";
    }

    public int Sumar()
    {
        int sumaIzq = this.Izquierdo == null ? 0 : this.Izquierdo.Sumar();
        int sumaDer = this.Derecho == null ? 0 : this.Derecho.Sumar();

        return sumaDer + sumaIzq + this.Valor;
    }

    public static int[] Concatenar(int[] a, int[] b)
    {
        int[] resultado = new int[a.Length + b.Length];
        int final = 0;

        for(int i = 0; i < a.Length; i++)
        {
            resultado[i] = a[i];
            final = i;
        }

        for(int j = 0; j < b.Length; j++)
        {
            resultado[a.Length - 1 + j] = b[j];
        }

        return resultado;
    }
}