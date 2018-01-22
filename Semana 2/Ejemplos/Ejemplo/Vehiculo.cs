using System;
public class Vehiculo{

    public virtual double VelocidadMaxima{get;} = 1;

    /*
    Las propiedades son metodos ligeros que no deben modificar
    nada mas que su propio valor
    */
    public double Velocidad{
        get;
        private set;
    }

    /**
    La direccion en que avanzara el vehiculo.
     */
    public Vector Direccion{get;}

    public Vector Posicion{get;}

    public Vehiculo(){
        this.Velocidad = this.VelocidadMaxima;
        this.Direccion = new Vector();
        this.Direccion.Sumar(1,0);
        this.Posicion = new Vector();
    }

    /**
    Definimos un metodo virtual, de tal manera que el comportamiento
    de ese metodo pueda ser cambiado por las sub-clases de esta
    clase.
    */
    protected virtual bool PosicionEsValida(double x, double y){

        Terreno[][] mapa = Mapas.Lago;
        return x >= 0 && x < mapa.Length
            && y >= 0 && mapa[(int)x].Length > y;
    }

    public void Avanzar(){

        double newX = this.Posicion.X + this.Direccion.X*this.Velocidad;
        double newY = this.Posicion.Y + this.Direccion.Y*this.Velocidad;

        if(this.PosicionEsValida(newX, newY)){
            this.Posicion.Sumar(this.Direccion.X*this.Velocidad, this.Direccion.Y*this.Velocidad);
        }
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

    public void Alcanzar(Vehiculo ladron){
        
        double angulo = this.AnguloDeAlineacion(ladron);
        double magDir = this.MagnitudDireccion(ladron);

        this.Rotar(angulo);

        double velocidad = this.VelocidadMaxima;

        if(this.VelocidadMaxima > magDir){
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