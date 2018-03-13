using System;

public class Numero{

    private Numero predecesor;

    public Numero(Numero predecesor = null){
        this.predecesor = predecesor;
    }

    public static bool EsCero(Numero n){
        return n == null;
    }

    public static Numero Sumar(Numero n1, Numero n2){

        // Primer caso base
        if(Numero.EsCero(n1)){
            return n2;
        }
        
        if(Numero.EsCero(n2)){
            return n1;
        }

        Numero n = n1.predecesor;

        return new Numero(Numero.Sumar(n, n2));
    }

    // Javier Alvarez
    // Mario Pons
    // Jose Gaytan
    // Anibal Higuero
    public static Numero Resta(Numero n1, Numero n2){

        if(Numero.EsCero(n1) && !Numero.EsCero(n2)){
            throw new Exception("Resta no esta definida para <null>");
        }

    }

    public static Numero Mult(Numero n1, Numero n2){

    }

    public static int ToInt(Numero n){
        if(EsCero(n)){
            return 0;
        }

        return 1 + ToInt(n.predecesor);
    }
}