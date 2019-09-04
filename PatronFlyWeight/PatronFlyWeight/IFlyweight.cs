using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFlyWeight
{
   public interface IFlyweight
    {

        void ColocarNombre(string pNombre);
        void CalcularCosto();
        void Mostrar();
        String ObtenNombre();


    }
}
