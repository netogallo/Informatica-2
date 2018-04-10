using System;

public class BinaryIntTree : BinaryTree<int>, IBinIntTree
{
    public BinaryIntTree(
        int valor,
        IBinTree<int> derecho,
        IBinTree<int> izquierdo) : base(valor, derecho, izquierdo)
    {
    }

    public BinaryIntTree(int valor) : base(valor) {}

    public int Sumar()
    {
        return this.Reduce(0, (izq, der, valor) => izq + der + valor);
    }

    public int Menor()
    {
        return this.Reduce(this.Valor, (izq, der, valor) => Math.Min(Math.Min(izq, der), valor));
    }
}