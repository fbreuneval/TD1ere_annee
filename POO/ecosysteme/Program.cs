using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ecosysteme
{
    class Program
    {
        static void Main(string[] args)
        {

            //! relation d'héritage = "est un" et non "a un".

            Insecte insect = new Insecte(5, 0, 0);

            for (int i = 0; i < 32; i++)
            {
                insect.Deplacer();
                insect.Manger();
            }

            Console.WriteLine(insect); // pas besoin d'appeller une méthode dans le write puisque on a utilisé la méthode spécifique "override string ToString".

            Simulation simu = new Simulation(4, 10);
            simu.Simuler();
            Console.WriteLine(simu);


            Cigale cigale = new Cigale(2, 3);
            Console.WriteLine(cigale);

            Console.ReadKey();
        }
    }
}
