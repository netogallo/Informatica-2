public interface ILinea<T>{
    double Longitud();

    T PuntoMasCercano(T punto);
}