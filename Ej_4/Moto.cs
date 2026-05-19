using System;

namespace Ej_4
{
    public class Moto : Vehiculo
    {
        private int cilindrada;

        public Moto(string patente, string modelo, int cilindrada) : base(patente, modelo)
        {
            this.cilindrada = cilindrada;
        }

        public override void imprimirDatos()
        {
            base.imprimirDatos();
            Console.WriteLine($"Cilindrada: {cilindrada}cc");
        }
    }
}