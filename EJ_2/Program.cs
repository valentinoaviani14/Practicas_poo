using EJ_2;
using System;

namespace Ej_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cronómetro crono = new Cronómetro();
            for (int i = 0; i < 5000; i++)
            {
                crono.incrementarTiempo();
            }
            Console.WriteLine(crono.mostrarTiempo());
        }
    }
}
