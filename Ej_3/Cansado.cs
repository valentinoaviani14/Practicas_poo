using System;

namespace Ej_3
{
    public class Amateur : IJugador
    {
        private int minutosCorriendo = 0;
        private bool estaCansado = false;

        public bool correr(int minutos)
        {
            if (!estaCansado)
            {
                if (minutosCorriendo + minutos > 20)
                {
                    estaCansado = true;
                    return false;
                }

                minutosCorriendo += minutos;
                return true;
            }

            return false;
        }

        public bool cansado() => estaCansado;

        public void descansar(int minutos)
        {
            for (int i = 0; i < minutos; i++)
            {
                if (minutosCorriendo > 0)
                {
                    minutosCorriendo--;
                }
            }

            if (minutosCorriendo == 0)
            {
                estaCansado = false;
            }
        }
    }
}