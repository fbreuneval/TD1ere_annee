using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vehicule
{
    class Voiture : Vehicule
    {
        protected double _poids;
        protected string _couleur;
        protected int _puissance;
 
        public Voiture(int places, int km, double poids, string couleur, int puissance)
            : base(4, places, km)
        {
            _poids = poids;
            _puissance = puissance;
            _couleur = couleur;
        }

        public override string ToString()
        {
            return "( Voiture )  " + base.ToString() + "son poids est " + _poids + " kg sa couleur est " + _couleur + " et sa puissance: " + _puissance + "W.";
        }
    }
}
