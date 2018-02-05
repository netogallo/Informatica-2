using System;

public class Vehiculo: Localizable, IMover{

    public double Velocidad{get; private set;}

    public Vehiculo(){
        this.Velocidad = 1;
    }

    public void Mover(double x, double y){
        // Mover en la direccion dada
        double magnitud = Math.Sqrt(x*x + y*y);
        double dx = x/magnitud;
        double dy = y/magnitud;

        this.X += dx*this.Velocidad;
        this.Y += dy*this.Velocidad;
    }
}