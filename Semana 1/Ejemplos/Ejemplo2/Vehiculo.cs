using System;
class Vehiculo{

    const double VELOCIDAD_MAXIMA = 1.0;

    /*
    Las propiedades son metodos ligeros que no deben modificar
    nada mas que su propio valor
    */
    public double Velocidad{
        get;
        private set;
    }

    public Vector Direccion{get;}

    public Vector Posicion{get;}

    public void Avanzar(){
        this.Direccion.Sumar(this.Posicion.X*this.Velocidad, this.Posicion.Y*this.Velocidad);
    }

    public void Rotar(double angulo){
        this.Direccion.Rotar(angulo);
    }

    public double MagnitudDireccion(Vehiculo otro){
        double dirX = this.Posicion.X - otro.Posicion.X;
        double dirY = this.Posicion.Y - otro.Posicion.Y;
        return Math.Sqrt(dirX*dirX + dirY*dirY);
    }

    public double AnguloDeAlineacion(Vehiculo otro){
        double dirX = this.Posicion.X - otro.Posicion.X;
        double dirY = this.Posicion.Y - otro.Posicion.Y;

        double prod = this.Direccion.X * dirX + this.Direccion.Y * dirY;
        double magThis = this.Direccion.Magnitud();
        double magDir = this.MagnitudDireccion(otro);
        return Math.Acos(prod/(magThis*magDir));
    }

    public void Escapar(Vehiculo ladron){

    }

    public void Alcanzar(Vehiculo ladron){
        
        double angulo = this.AnguloDeAlineacion(ladron);
        double magDir = this.MagnitudDireccion(ladron);

        this.Rotar(angulo);

        double velocidad = VELOCIDAD_MAXIMA;

        if(VELOCIDAD_MAXIMA > magDir){
            velocidad = magDir;
        }

        this.Velocidad = velocidad;
        double distRestante = magDir;

        while((distRestante - this.Velocidad) >= 0){
            this.Avanzar();
            distRestante -= this.Velocidad;
        }

        if(distRestante > 0.001){
            this.Velocidad = distRestante;
            this.Avanzar();
        }
    }
}