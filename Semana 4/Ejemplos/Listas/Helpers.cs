public class Helpers{

    public static IList<T> Concat<T>(
        IList<T> l1,
        IList<T> l2){

        if(l1.Length == 0){
            return l2;
        }

        IList<T> resultado = new LinkedList<T>(l1.Get(0));

        for(int i = 1; i < l1.Length; i++){
            resultado.Push(l1.Get(i));
        }

        for(int i = 0; i < l2.Length; i++){
            resultado.Push(l2.Get(i));
        }

        return resultado;

    }
}