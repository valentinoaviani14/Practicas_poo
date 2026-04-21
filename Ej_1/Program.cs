using System;

namespace Ej_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Semaforo miSemaforo = new Semaforo("Verde");
            miSemaforo.mostrarColor();

            miSemaforo.pasoDelTiempo(20);
            miSemaforo.mostrarColor();
        }
    }
}
