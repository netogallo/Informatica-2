using System;

namespace Vehiculo
{
    /*
    A continuacion definimos la clase llamada Vehiculo, para representar
    diversos vehiculos.
    */
    class Vehiculo
    {

        private int velocidad;

        /*
        A continuacion definimos un constructor que permite
        crear instancias de vehiculos.
         */
        public Vehiculo(string nombre){
            this.Nombre = nombre;
            this.dx = 1;
            this.dy = 0;
            this.x = 0;
            this.y = 0;
            this.velocidad = 1;
        }

        /*
        A continuacion se define la marca del vehiculo como primera
        propiedad.
        */
        public string Nombre{get;}

        /*
        A continuacion se define el componente x de la
        posicion del vehiculo 
        */
        private int x;

        /*
        A continuacion se define el accesor de la
        posicion.
        */
        public int X{
            get{return this.x;}
        }

        /*
        A continuacion se define el componente y de la
        posicion del vehiculo
        */
        private int y;

        /*
        A continuacion se define el accesor del componente
        y de la posicion.
        */
        public int Y{
            get{return this.y;}
        }

        /*
        A continuacion se define el componente x de la direccion
        del vehiculo.
        */
        private int dx;

        /*
        A continuacion se define un accessor para el componente x
        de la direccion del vehiculo.
        */
        public int Dx{
            get{return this.dx;}
        }

        private int dy;

        public int Dy{
            get{return this.dy;}
        }

        /*
        Operacion que permite que el vehiculo avanze
        en su direccion actual.
        */
        public void Avanzar(){
            this.x += this.dx * this.velocidad;
            this.y += this.dy * this.velocidad;
        }

        public void Acelerar(int cantidad){
            this.velocidad += cantidad;
        }

        /*
        Operazion que rota el vehiculo 90 grados
        a la izquierda
        */
        public void RotarIzquierda(){
            int dx = this.dx;
            int dy = this.dy;
            this.dx = -dy;
            this.dy = dx;
        }

        public override string ToString(){
            return $"Nombre: {this.Nombre}\nUbicacion: ({this.X}, {this.Y})";
        }
    }
}
