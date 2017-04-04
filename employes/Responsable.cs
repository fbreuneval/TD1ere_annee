using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace employes
{
    class Responsable : Employe 
    {
        public Employe[] tabSubordonnes;

        public Responsable(string nom, double ind, Employe[] subordonnes ) : base ( nom, ind) 
        {
            tabSubordonnes = subordonnes;
        }

        public void AfficheSubordonnes ()
        {
            for (int i =0;i< tabSubordonnes.Length;i++)
            {
                Console.WriteLine(tabSubordonnes[i].nom);
            }
        }

    }



}
