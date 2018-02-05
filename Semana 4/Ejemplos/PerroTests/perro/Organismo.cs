public abstract class Organismo: Localizable{

    public int Energia{get; protected set;}

    public abstract int Metabolizar(string alimento);

    public void Alimentar(string alimento){
        this.Energia += this.Metabolizar(alimento);
    }
}