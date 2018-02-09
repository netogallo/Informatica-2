using System;

public interface IList<T>
{
    T Get(int indice);
    bool Set(int indice, T elemento);
    void Push(T elemento);
}