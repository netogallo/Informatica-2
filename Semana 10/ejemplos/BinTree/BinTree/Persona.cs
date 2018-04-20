public class Persona
{
    public int Id {get;}

    public string Nombre {get;}


    public int Edad {get; private set;}
    public Persona(int id, string nombre, int edad)
    {
        Id = id;
        Nombre = nombre;
        Edad = edad < 0 ? 0 : edad;
    }

    public void Cumple()
    {
        Edad += 1;
    }

    public override string ToString()
    {
        return $"Persona({Id}, {Nombre}, {Edad})";
    }
}