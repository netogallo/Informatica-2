using System;

public class Perro: Organismo, IMover{
    
    public Perro(){
        this.Velocidad = 1;
    }

    public override int Metabolizar(string alimento){
        if(alimento == "carne"){
            return 100;
        }

        return 0;
    }

    public double Velocidad{get; private set;}


    /*
    Todo: Cada vez que el perro se mueva,
    restar una unidad de energia por
    unidad de movimiento.
    */
    public void Mover(double x, double y){

        if(this.Energia <= 0){
            return;
        }

        // Mover en la direccion dada
        double magnitud = Math.Sqrt(x*x + y*y);
        double dx = x/magnitud;
        double dy = y/magnitud;

        this.X += dx*this.Velocidad;
        this.Y += dy*this.Velocidad;
    }

}