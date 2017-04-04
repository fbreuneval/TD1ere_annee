using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace employes
{
    class Program
    {
        static void Main(string[] args)
        {
            Employe jj = new Employe("Jean-Jacques", 1.2);
            Employe jn = new Employe ("Jean-noël",1.2);
            Employe mj = new Employe ("Marie-Jeanne",1.3);
          
            Employe[] tabSubordonnes = new Employe[] {jn,mj,jj};

            Responsable jp = new Responsable("Jean-Pierre", 1.4, tabSubordonnes);

            //info sur mr J.J. :
            Console.WriteLine("voici les infos de monsier "+jj.nom);
            Console.WriteLine("Matricule n° " + jj.Matricule);
            Console.WriteLine("Son salaire : "+ jj.Salaire);
            Console.WriteLine("Avec salaire de base = " + jj.SalaireBase+"\n");

            //Afficher tab de subordonnés : 
            Console.WriteLine("\n Les employés de "+jp.nom+" :");
            jp.AfficheSubordonnes();

            Commercial commercial = new Commercial("Commercial", 1.3, 10);
            Console.WriteLine("Son salaire : " +commercial.Salaire);
            
            Console.ReadKey();  
        }
    }
}
