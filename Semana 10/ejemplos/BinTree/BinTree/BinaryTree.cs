using System;
using System.Linq;

public class BinaryTree<U> : IBinTree<U>{
    public U Valor {get; set;}

    public IBinTree<U> Derecho {get; set;}

    public IBinTree<U> Izquierdo {get; set;}

    private readonly Func<U,U,bool> comparacion;

    public BinaryTree(
        U valor,
        IBinTree<U> derecho,
        IBinTree<U> izquierdo,
        Func<U,U, bool> comparacion){
        this.Valor = valor;
        this.Derecho = derecho;
        this.Izquierdo = izquierdo;
        this.comparacion = comparacion;
    }

    public BinaryTree(U valor,  Func<U,U, bool> comparacion){
        this.Valor = valor;
        this.comparacion = comparacion;
    }

    public BinaryTree(U valor){
        this.Valor = valor;
    }

    public BinaryTree(
        U valor,
        IBinTree<U> derecho,
        IBinTree<U> izquierdo){
        this.Valor = valor;
        this.Derecho = derecho;
        this.Izquierdo = izquierdo;
    }

    public override string ToString(){
        string derecho = this.Derecho == null ? string.Empty : this.Derecho.ToString();
        string izquierdo = this.Izquierdo == null ? string.Empty : this.Izquierdo.ToString();
        return $"{this.Valor} \n\t {derecho} \n\t {izquierdo}";
    }
    public T Reduce<T>(T inicial, Func<T, T, U, T> fn)
    {
        T izquierdo = this.Izquierdo == null ? inicial : this.Izquierdo.Reduce<T>(inicial, fn);
        T derecho = this.Derecho == null ?  inicial : this.Derecho.Reduce<T>(inicial, fn);

        return fn(izquierdo, derecho, this.Valor);
    }

    public U[] ToArray()
    {
        return this.Reduce<U[]>(new U[]{}, (izquierdo, derecho, valor) => {
            return izquierdo.Concat(new U[]{valor}).Concat(derecho).ToArray();
        });
    }

    public void Insert(U valor)
    {
        if(comparacion(valor, Valor))
        {
            if(Izquierdo == null)
            {
                Izquierdo = new BinaryTree<U>(valor, comparacion);
            }
            else
            {
                Izquierdo.Insert(valor);
            }
        }
        else
        {
            if(Derecho == null)
            {
                Derecho = new BinaryTree<U>(valor, comparacion);
            }
            else
            {
                Derecho.Insert(valor);
            }
        }
    }

    public U BinarySearch(U obj)
    {

        new object();

        if(obj.Equals(Valor))
        {
            return Valor;
        }

        if(comparacion(obj, Valor) && Izquierdo != null)
        {
            return Izquierdo.BinarySearch(obj);
        }
        else if(Derecho != null)
        {
            return Derecho.BinarySearch(obj);
        }

        throw new Exception();
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