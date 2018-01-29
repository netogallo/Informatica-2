public class Gato: Animal{
    public override int Metabolizar(string alimento){

        if(alimento == "leche"){
            return 50;
        }

        return 0;
    }
}