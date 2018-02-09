public class LinkedList<T>: IList<T>
{
    public T Elemento{get; private set;}
    public LinkedList<T> Resto{get; private set;}

    public LinkedList(T elemento)
    {
        this.Elemento = elemento;
        this.Resto = null;
    }

    /* Todo: implementar */
    public bool Set(int indice, T valor){ return false; }

    public void Push(T elemento){
        
        LinkedList<T> lista = this;

        while(lista.Resto != null)
        {
            lista = lista.Resto;
        }

        lista.Resto = new LinkedList<T>(elemento);
    }

    public T Get(int indice)
    {
        if(indice < 0)
        {
            return null;
        }

        int actualIndice = 0;
        LinkedList<T> actual = this;

        while(actualIndice++ < indice)
        {

            if(actual == null)
            {
                return null;
            }

            actual = actual.Resto;
        }

        return actual.Elemento;
    }
}