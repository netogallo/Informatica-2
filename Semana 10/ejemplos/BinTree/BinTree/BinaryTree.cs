
public class BinaryTree : IBinTree{
    public int Valor {get;}

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
}