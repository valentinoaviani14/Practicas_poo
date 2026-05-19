using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_4
{
    public class Vehiculo
    {
        protected string patente;
        protected string modelo;

        public Vehiculo(string patente, string modelo)
        {
            this.patente = patente;
            this.modelo = modelo;
        }
        public virtual void imprimirDatos()
        {
            Console.WriteLine($"Patente: {patente}, Modelo: {modelo}");
        }
    }
}
