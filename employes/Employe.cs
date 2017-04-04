using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace employes
{
    class Employe
    {
        public string nom;
        protected int _matricule;
        protected double _indSalarial;
        protected static double _salaireBase = 1149;
        private static int _compteur = 0;

        public Employe(string unnom, double ind)
        {
            nom = unnom;
            _matricule = _compteur + 1;
            _indSalarial = ind;
            _compteur++;
        }

        public int Matricule // !! on ajoute pas les parenthèses après le nom pour les méthodes get/set
        { get { return _matricule; } }

        public double SalaireBase
        {
            get { return _salaireBase; }
            set { _salaireBase = value; }
        }

        public virtual double Salaire
        {
            get { return _indSalarial * _salaireBase; }
            set { _indSalarial = value; }
        }

    }
}
