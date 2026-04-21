using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_1
{
    public class Semaforo
    {
        private int segundosActuales;
        private bool esIntermitente;

        public Semaforo(string colorInicial)
        {
            esIntermitente = false;
            if (colorInicial == "Verde") segundosActuales = 32;
            else if (colorInicial == "Amarillo") segundosActuales = 52;
            else if (colorInicial == "Rojo + Amarillo") segundosActuales = 30;
            else segundosActuales = 0;
        }
        public void pasoDelTiempo(int segundos)
        {
            segundosActuales = (segundosActuales + segundos) % 54;
        }
        public void mostrarColor()
        {
            if (esIntermitente)
            {
                if (segundosActuales % 2 == 0) Console.WriteLine("color actual: Amarillo (intermitente)");
                else Console.WriteLine("color actual: Apagado");
            }
            else
            {
                if (segundosActuales < 30) Console.WriteLine("Color actual: Rojo"); 
                else if (segundosActuales < 32) Console.WriteLine("Color actual: Rojo + Amarillo");
                else if (segundosActuales < 52) Console.WriteLine("Color actual: Verde");
                else Console.WriteLine("Color actual: Amarillo"); 
            }
        }
        public void ponerEnIntermitente() => esIntermitente = true;
        public void sacarDeIntermitente() => esIntermitente = false;
    }
}

