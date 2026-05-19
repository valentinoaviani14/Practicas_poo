using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_3
{
    public interface IJugador
    {
        bool correr(int minutos);
        bool cansado();
        void descansar(int minutos);
    }
}
