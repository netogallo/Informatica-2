public class Program{

    public static void Main(string[] args){
        string[] valores = new string[]{"Reduce", "es", "fold"};

        // Concatenar un array de strings mediante
        // commas
        Func<string,string,string> reduccion1 = (acc, valor) => {
            if(acc == string.Empty){
                return valor;
            }else{
                return acc + ", " + valor;
            }
        };
        Program.Reduce<string, string>(valores, string.Empty, reduccion1);
        // Produce "Reduce, es, fold"


        // Contar las letras en un array de strings
        Func<int, string, int> reduccion2 = (acc, valor) => acc + valor.Length;
        Program.Reduce<string, int>(valores, 0, reduccion2); // Produce 10
    }
}