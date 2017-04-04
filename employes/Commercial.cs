using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace employes
{
    class Commercial : Employe
    {
        public int nbVentesDernierMois;
        public int indInteressement=3 ;

        public Commercial(string nom, double ind, int nbVentes) : base(nom, ind) { nbVentesDernierMois = nbVentes; }

        public override double Salaire // redifinition de la méthode "Salaire" virtuelle grâce au modificateur override. 
        {
            get { return _indSalarial * _salaireBase + indInteressement*nbVentesDernierMois; }
            set { _indSalarial = value; }
        }

        public int nbVentes
        {
            get { return nbVentesDernierMois; }
            set { nbVentesDernierMois = value; }
        }
    }
}
