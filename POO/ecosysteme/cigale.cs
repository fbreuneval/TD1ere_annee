using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ecosysteme
{
    class Cigale : Insecte
    {
       
        public Cigale (int x, int y)  // constructeur
            : base(5,x,y)
        {
        }

        /* POSSIBILITE
        * public Cigale (int x, int y)
        {
        this._faim = 5;
        this._dernierRepas = 0;
        this._abscisse = x;
        this._ordonnee = y; */

        public override string  ToString()
        {
            return "Je suis une cigale," + base.ToString(); // appel à la methode to string des insectes.
        }
    }
}
