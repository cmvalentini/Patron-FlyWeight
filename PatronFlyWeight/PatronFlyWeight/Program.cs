using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFlyWeight
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;

            List<int> Americana = new List<int>();
            List<int> Italiana = new List<int>();
            List<int> Mexicana = new List<int>();

            List<int> Carnes = new List<int>();
            List<int> Sopas = new List<int>();
            List<int> Ensaladas = new List<int>();


            List<int> Rapida = new List<int>();


            CflyweightFactory flywf = new CflyweightFactory();

            i = flywf.adiciona("Hamburguesas");

            Americana.Add(i);
            Carnes.Add(i);
            Rapida.Add(i);

            i = flywf.adiciona("Chicken fingers");
            Americana.Add(i);
            Ensaladas.Add(i);

            i = flywf.adiciona("Sopa de verduras ");
            Italiana.Add(i);
            Sopas.Add(i);

            i = flywf.adiciona("Bruschetta");
            Italiana.Add(i);
            Ensaladas.Add(i);

            i = flywf.adiciona("Tacos al Pastor");
            Mexicana.Add(i);
            Carnes.Add(i);
            Rapida.Add(i);

            i = flywf.adiciona("Tagliatelli");
            Italiana.Add(i);
            Sopas.Add(i);

            i = flywf.adiciona("Pizza");
            Italiana.Add(i);
            Rapida.Add(i);

            Console.WriteLine("------------");
            foreach (int n in Rapida)
            {
                Creceta receta = (Creceta)flywf[n];
                receta.CalcularCosto(); //estado extrinseco, no se encuentra de manera natural en el objeto
                receta.Mostrar(); //estado intrinseco, comun a todos los objetos iguales
            }
            Console.WriteLine("------------");

            Console.WriteLine("---No se muestra el estado extrinseco aqui debajo-----");
            foreach (int n in Americana)
            {
                Creceta receta = (Creceta)flywf[n];
                //   receta.CalcularCosto();  
                receta.Mostrar(); //estado intrinseco, comun a todos los objetos iguales
            }
            Console.WriteLine("------------");

            Console.WriteLine("---este objeto ya lo incluimos en el Factory----");
            i = flywf.adiciona("Pizza");
            Console.WriteLine("------------");

            Console.WriteLine("---MOSTRAMOS TODAS LAS RECETAS----");

            int M = 0;

            for (int m = 0; m < flywf.Conteo; m++)
            {
                Creceta receta = (Creceta)flywf[m];
                receta.Mostrar();
            }

            Console.ReadLine();


        }
    }
}
