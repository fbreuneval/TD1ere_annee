using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace employes
{
    class Employe
    {
        protected string _nom;
        protected int _matricule;
        protected double _indSalarial;
        private static double _salaireBase=1480;
        private static int _compteur=0;

        private Employe (string nom, double ind)
    {
        _nom=nom;
        _indSalarial=ind;
        _matricule = _compteur;
        _compteur++;
    }
        public int Matricule // !! pas de parenthèses pour les méthodes get/set
        {get{ return _matricule;}}

        public double SalaireBase 
        {
            get ;
            set ;
        }

        public double Salaire
        {
            get { return _indSalarial*_salaireBase;}
           set { _indSalarial=value;}
        }


        }
    }
