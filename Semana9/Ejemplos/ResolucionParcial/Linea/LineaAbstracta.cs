public abstract class LineaAbstracta<T> : ILinea<T>{

    public abstract double Distancia(T p1, T p2);

    public abstract T[] Puntos {get;}

    public T PuntoMasCercano(T punto){

        T resultado = Puntos[0];

        for(int i = 0; i < Puntos.Length; i++){

            if(Distancia(punto, Puntos[i]) < Distancia(punto, resultado)){
                resultado = Puntos[i];
            }
        }

        return resultado;
    }

    public double Longitud(){

        if(this.Puntos.Length == 0 || this.Puntos.Length == 1){
            return 0;
        }

        double total = 0;

        for(int i = 0;i < this.Puntos.Length - 1; i++){
            T p1 = this.Puntos[i];
            T p2 = this.Puntos[i + 1];
            total += this.Distancia(p1, p2);
        }

        return total;
    }
}