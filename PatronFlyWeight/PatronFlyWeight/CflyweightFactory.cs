using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFlyWeight
{
   public  class CflyweightFactory
    {
        private List<IFlyweight> flyweights = new List<IFlyweight>();
         
        private int conteo = 0;

        public int Conteo
        {
            get { return conteo; }
            set { conteo = value; }
        }

        public int adiciona(string pNombre)
        {

            //verificamos si existe
            bool existe = false;

            foreach (IFlyweight f in flyweights)
            {
                if (f.ObtenNombre() == pNombre)
                {
                    existe = true;
                }
            }
            if (existe)
            {
                Console.WriteLine("El objeto ya existe,no se ha adicionado");
                return -1;
            }
            else
            {
                Creceta miReceta = new Creceta();
                miReceta.ColocarNombre(pNombre);
                flyweights.Add(miReceta);
                conteo = flyweights.Count;

                return conteo - 1;//devuelvo el indice
            }
        }
            public IFlyweight this[int index] {
            get {
                return flyweights[index];
              }
                                             }


        }





    }

