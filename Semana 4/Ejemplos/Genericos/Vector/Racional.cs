public class Racional{
    public int Divisor{get;}
    public int Dividendo{get;}

    public Racional(int dividendo, int divisor){
        this.Divisor = divisor;
        this.Dividendo = dividendo;
    }

    public override string ToString(){
        return $"{this.Dividendo}/{this.Divisor}";
    }
}