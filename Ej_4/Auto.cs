using System;

namespace Ej_4
{
    public class Auto : Vehiculo
    {
        private int cantidadPuertas;
        public Auto(string patente, string modelo, int puertas) : base(patente, modelo)
        {
            this.cantidadPuertas = puertas;
        }

        public override void imprimirDatos()
        {
            base.imprimirDatos(); 
            Console.WriteLine($"Puertas: {cantidadPuertas}");
        }
    }
}