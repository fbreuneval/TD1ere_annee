using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ecosysteme
{
    class Fourmi : Insecte
    {
         public Fourmi (int x, int y) // constructeur
            : base(7,x,y)
        {
        }

         public override string ToString()
         {
             return "Je suis une fourmi," + base.ToString(); // appel à la methode to string des insectes.
         }
    }
}
