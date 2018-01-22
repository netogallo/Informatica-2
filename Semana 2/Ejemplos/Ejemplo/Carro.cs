/**
Se define una propiedad enumerada de manera que
sea mas facil identificar cada una de las llantas
del vehiculo.
 */
public enum LlantaDeCarro{
    DerechaDelantera = 0,
    DerechaTrasera = 1,
    IzquierdaDelantera = 2,
    IzquierdaTrasera = 3
}

public class Carro: Vehiculo{

    private double PresionLLanta1;
    private double PresionLlanta2;
    private double PresionLlanta3;
    private double PresionLLanta4;

    public override double VelocidadMaxima{get;} = 3.0;

    /**
    Se modifica el comportamiento del metodo "PosicionEsValida"
    de tal manera que el metodo tambien revise que el tipo de
    terreno en la nueva posicion del vehiculo es valida.
     */
    protected override bool PosicionEsValida(double x, double y){
        if(!base.PosicionEsValida(x,y)){
            return false;
        }

        Terreno terreno = Mapas.Lago[(int)x][(int)y];
        return terreno == Terreno.Calle || terreno == Terreno.Tierra;
    }

    public void InflarLlanta(LlantaDeCarro llanta, double presion){
        switch(llanta){
            case LlantaDeCarro.DerechaDelantera:
                this.PresionLLanta1 = presion;
                break;
            case LlantaDeCarro.DerechaTrasera:
                this.PresionLlanta2 = presion;
                break;
            case LlantaDeCarro.IzquierdaDelantera:
                this.PresionLlanta3 = presion;
                break;
            case LlantaDeCarro.IzquierdaTrasera:
                this.PresionLLanta4 = presion;
                break;
        }
    }    
}