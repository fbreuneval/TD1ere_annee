using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ecosysteme
{
    class Simulation // a comme attribut une liste d'insecte (cf association avc inscte)
    {
        private int _nbTours; // nb tours à affectuer (entre 0 et 10)
        private int _yMax;
        private int _xMax;
        public Random alea = new Random(); // utilisé pour la valeur "faim".
        private List<Insecte> _insectes;

        public Simulation(int tours, int nbInsectes)
        {
            this.alea = new Random();
            this._insectes = new List<Insecte>(); // important. (sinon "null reference exception")
            this._nbTours = tours;

            for (int i = 0; i < nbInsectes; i++) // ajout de nbInsectes insectes.
            {
                //trois entiers qui serviront de paramètres

              /*  switch (alea.Next(3)) //Incomplet encore, pour faire des cas à proba égales.
                {

                } */


                int faim = alea.Next(0, 11);
                int x = alea.Next(0, _xMax + 1);
                int y = alea.Next(0, _yMax + 1);
                if (faim == 5)
                {
                    Cigale cigale = new Cigale(x, y);
                    _insectes.Add(cigale);
                }
                else if(faim==7)
                {
                    Fourmi fourmi = new Fourmi(x, y);
                    _insectes.Add(fourmi);
                }
                else
                {
                    Insecte insecte = new Insecte(faim, x, y);
                    _insectes.Add(insecte);
                }
                // OU _insectes.Add(new _insectes)
            }

        }

        public void Simuler()
        {
            for (int i = 0; i < _nbTours; i++)
            {
                this.simuleUnTour();
            }
        }

        public void simuleUnTour()
        {

            foreach (Insecte bete in _insectes) // dans l'ordre : Classe, variable (string), liste.
            {
                bete.Deplacer();  // utilisation des méthodes de la classe insectes grâce au "foreach" qui s'applique à la liste d'insectes.
                bete.Manger();
            }
          
            /* OU 
             * for( int i=0; i<_insectesCount<i++)
             * {
             *      //on a insectes[i] éléments de liste qui représente chaque insecte. 
             * 
             * }
             * */
        }
        
        public override string ToString() // renvoie description textuelle
        {
                 string description ="";
                 foreach (Insecte insecte in _insectes)
                 {
                     description += insecte + "\n";
                 }
                 return description;

        }
    }
}
