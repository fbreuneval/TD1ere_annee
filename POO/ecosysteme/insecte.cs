using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ecosysteme
{
    class Insecte
    {
        protected int _faim; // indique à partir de cbien de tours l'insecte aura faim
        protected int _dernierRepas; // indique le nombre de tours effectués depuis le dernier repas
        protected int _abscisse;
        protected int _ordonnee;

        public Insecte (int nbFaim, int x, int y)
        {
            this._faim = nbFaim;
            this._dernierRepas = 0;
            this._abscisse = x;
            this._ordonnee = y;
        }

        public void Manger()
        {

            if (this._dernierRepas == this._faim)
                this._dernierRepas = 0; 
            else
                this._dernierRepas++;
        }

        public void Deplacer()
        {
            this._abscisse++;
            this._ordonnee++;
        }

        public override string ToString() // renvoie description textuelle, override car existe en c#.
        {
            string caract = "L'insecte est situé à la position d'abscisse" + this._abscisse + "et d'ordonnée " + this._ordonnee +
                ", il mange après" + this._faim + "tours et cela fait " + this._dernierRepas + "tours qu'il a mangé.";
            return caract;
        }



    }
}
