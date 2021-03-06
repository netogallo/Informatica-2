public class Coleccion: IColeccion{
    private int valor;

    public int Get(int indice){
        if(indice == 0){
            return this.valor;
        }

        return 0;
    }

    public void Set(int indice, int valor){
        if(indice == 0){
            this.valor = valor;
        }
    }

    public int Size{
        get{return 1;}
    }

    public IColeccion Duplicar(){
        IColeccion copia = new Coleccion();
        copia.Set(0, this.Get(0));
        return copia;
    }
}