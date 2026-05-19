using System;

namespace Ej_4
{
    public class Camion : Vehiculo
    {
        private double cargaMaxima;

        public Camion(string patente, string modelo, double carga) : base(patente, modelo)
        {
            this.cargaMaxima = carga;
        }

        public override void imprimirDatos()
        {
            base.imprimirDatos();
            Console.WriteLine($"Carga Máxima: {cargaMaxima}kg");
        }
    }
}