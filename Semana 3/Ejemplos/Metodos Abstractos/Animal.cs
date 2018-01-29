using System;

public abstract class Animal{

    private int _energia;

    public int Energia{
        get{return this._energia;}
    }

    public Animal(){
        this._energia = 0;
    }

    public void Comer(string alimento){
        this._energia += this.Metabolizar(alimento);
    }

    public abstract int Metabolizar(string alimento);
}