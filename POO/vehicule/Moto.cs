using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vehicule
{
    class Moto : Vehicule
    {
        private double _poids;
        private string _couleur;
        private int _puissance;
 
        public Moto (int places, int km, double poids, string couleur, int puissance)
            : base(2,places,km)
        {
            _poids = poids;
            _puissance = puissance;
            _couleur = couleur;
        }

        public override string ToString()
        {
            return "( Moto ) " + base.ToString()+ "son poids est "+_poids+" kg sa couleur est "+_couleur+" et sa puissance: "+_puissance+"W.";
        }
    }
}
