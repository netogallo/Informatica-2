using System;

public class Vector{
    public double X{get; private set;}
    public double Y{get; private set;}

    public void Rotar(double angulo){
        double sinAngulo = Math.Sin(angulo);
        this.X = this.X * Math.Cos(angulo) - this.Y * sinAngulo;
        this.Y = this.X * sinAngulo + this.Y * Math.Cos(angulo);
    }

    public void Sumar(double x, double y){
        this.X += x;
        this.Y += y;
    }

    public double Magnitud(){
        return Math.Sqrt(this.X*this.X + this.Y*this.Y);
    }
}