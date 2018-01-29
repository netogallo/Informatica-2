public class Perro: Canino{

    public override int Metabolizar(string alimento){

        if(alimento == "carne"){
            return 100;
        }

        return 0;
    }
}