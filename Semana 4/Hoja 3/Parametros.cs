public class Program{
    public static bool Dividir(double num, double den, out double resultado){
        if(den != 0){
            resultado = num / den;
            return true;
        }else{
            return false;
        }
    }

    public static void Main(string[] args){
        double resultado = 0;

        if(Program.Dividir(32, 0, resultado)){
            Console.WriteLine($"La respuesta es {resultado}");
        }else{
            Console.WriteLine($"Error, el divisor no puede ser '0'!");
        }
    }
}