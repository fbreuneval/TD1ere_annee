using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace employes
{
    class Program
    {
        static void Main(string[] args)
        {
            Employe jj = new Employe("J.J", 1.2);
            jj.Matricule();

            Console.ReadKey();  
        }
    }
}
