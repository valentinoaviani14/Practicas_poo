using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_2
{
    public class Cronómetro
    {
        private int minutos;
        private int segundos;

        public Cronómetro()
        {
            reiniciar();
        }

        public void reiniciar()
        {
            segundos = 0;
            minutos = 0;
        }
        public void incrementarTiempo()
        {
            segundos++;
            if (segundos > 59)
            {
                segundos = 0;
                minutos++;
            }
        }
        public string mostrarTiempo()
        {
            return $"{minutos} minutos, {segundos} segundos";
        }
    }
}
