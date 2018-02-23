public class Program{

    public static void Main(string[] args){
        int[] valores = new int[]{1,2,3,4,5};

        // Contar elementos en un arreglo mediante
        // reduce
        Func<int,int,int> reduccion = (acc, valor) => acc + 1;
        Program.ReduceInt(valores, 0, reduccion); // Produce 5

        // Sumar los elementos de un arreglo mediante
        // reduce
        reduccion = (acc, valor) => acc + valor;
        Program.ReduceInt(valores, 0, reduccion); // Produce 15

        // Buscar el elemento mas grande en un
        // arreglo mediante reduce
        reduccion = (acc, valor) => {
            if(valor > acc){
                return valor;
            }else{
                return acc;
            }
        };
        Program.ReduceInt(valores, int.MinValue, reduccion); // Produce 5
    }
}