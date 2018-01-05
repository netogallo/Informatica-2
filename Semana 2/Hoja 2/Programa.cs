class Program{
    public static void main(string[] args){
        Persona turing = new Persona("Alan", "Turing");
        Persona alonzo = new Persona("Alonzo". "Church");

        QueHacer deber1 = new QueHacer("Inventar las ciencias de la computacion.");

        turing.AgregarQuehacer(deber1);
        alonzo.AgregarQuehacer(deber1);

        turing.CompletarQuehacer();

        Console.WriteLine("¿Estara disponible Alonzo?");
        Console.WriteLine(alonzo.EstaDisponible() ? "Si" : "No");
    }
}