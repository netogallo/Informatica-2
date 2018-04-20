using System;

public interface IBinTree<T>{
    T Valor {get;}

    IBinTree<T> Derecho {get; set;}

    IBinTree<T> Izquierdo {get; set;}

    U Reduce<U>(U inicial, Func<U, U, T, U> fn);

    T[] ToArray();

    void Insert(T valor);

    T BinarySearch(T obj);
}

public interface IBinIntTree : IBinTree<int>
{
    int Menor();

    int Sumar();
}