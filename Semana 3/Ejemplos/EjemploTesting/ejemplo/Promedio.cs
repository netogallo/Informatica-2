public class Promedio{
    public double CalcularPromedio(params double[] valores){
        double sumatoria = 0;

        for(int i = 0; i < valores.Length; i++){
            sumatoria += valores[i];
        }

        return sumatoria / valores.Length;
    }
}