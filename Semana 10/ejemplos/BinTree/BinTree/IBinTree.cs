using System;

public interface IBinTree<T>{
    T Valor {get;}

    IBinTree<T> Derecho {get;}

    IBinTree<T> Izquierdo {get;}

    U Reduce<U>(U inicial, Func<U, U, T, U> fn);

    T[] ToArray();
}

public interface IBinIntTree : IBinTree<int>
{
    int Menor();

    int Sumar();
}