using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polynomes
{
    class Program
    {
        static void Main(string[] args)
        {
            Monome m1 = new Monome();
            Monome m2 = new Monome(2, 4);
            Console.WriteLine("exp : "+m1.exposant+" coef : "+m1.coefficient);

            Console.WriteLine(m1);
            Console.WriteLine(m2);

            Console.ReadKey();
        }
    }
}
