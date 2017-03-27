using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vehicule
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicule v1=new Vehicule (4,6,100);
            Console.WriteLine(v1);


            Voiture voit1 = new Voiture(4, 200, 1000, "rouge", 100);
            Console.WriteLine(voit1);

            Opel opel1 = new Opel (4,100,1000,"bleu",200);
            opel1.capaciteReservoir= 100;
            opel1.consommation=1000;
            Console.WriteLine(opel1);
            Console.ReadKey();
        }
    }
}
