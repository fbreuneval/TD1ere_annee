using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vehicule
{
    class Opel : Voiture
    {
        public int consommation;
        public int capaciteReservoir;

        //2 constructeurs
        public Opel (int places, int km, double poids, string couleur, int puissance, int conso, int capRes) 
            : base (places,km,poids,couleur,puissance)
        {
        this.consommation = conso;
        this.capaciteReservoir = capRes;
      }

        public Opel(int places, int km, double poids, string couleur, int puissance)
            : base(places, km, poids, couleur, puissance)
        {
        }
      
        // méthodes get et set pour les variables d'instances (conso et cap reservoir)
        private int Consommation
        {
            get { return consommation; }
            set { if (value >=0) consommation = value; }
        }

        private int CapaciteReservoir
        {
            get { return capaciteReservoir; }
            set { if (value >= 0) capaciteReservoir = value; }
        }

        public override string ToString()
        {
            return "Marque: Opel. Sa consommation est de "+consommation+" et son réservoir a une capacité de"+capaciteReservoir+" litres."+ base.ToString() + "son poids est " + _poids + " kg sa couleur est " + _couleur + " et sa puissance: " + _puissance + "W.";
        }


        public object _couleur { get; set; }
    }


}

