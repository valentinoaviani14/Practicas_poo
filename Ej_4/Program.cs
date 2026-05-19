using System;

namespace Ej_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto miAuto = new Auto("ABC 123", "Fiat Cronos", 4);
            Moto miMoto = new Moto("999 XYZ", "Honda Wave", 110);
            Camion miCamion = new Camion("AAA 000", "Mercedes-Benz", 5000);

            miAuto.imprimirDatos();
            miMoto.imprimirDatos();
            miCamion.imprimirDatos();
        }
    }
}
