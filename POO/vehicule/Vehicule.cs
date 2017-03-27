using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vehicule
{
    class Vehicule
    {
        protected int _nbRoues;
        protected int _nbPlaces;
        protected double _kilometrage;

        public Vehicule(int roues, int places, int km)
        {
            this._nbRoues = roues;
            this._nbPlaces = places;
            this._kilometrage = km;
        }

        public override string ToString()
        {
            string descr = "Ce véhicule a " + _nbRoues + " roues " + ", " + _nbPlaces + " places et il a roulé" + _kilometrage+" kilomètres.";
            return descr;
        }
    }
}
