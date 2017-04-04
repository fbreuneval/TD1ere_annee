using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polynomes
{
    class Monome
    {
        public int coefficient;
        public int exposant;

        public int Coefficient
        {
            get { return coefficient; }
            set { if (value >= 0) { coefficient = value; } }
        }

        public int Exposant
        {
            get { return exposant; }
            set { if (value >= 0) { exposant = value; } }
        }

        public Monome(int coef, int exp)
        {
            coefficient = coef;
            exposant = exp;
        }

        public Monome() : this (0,0) { } // appel du constructeur qui contient deux arguments

        public override string ToString()
        {
            return (coefficient + " X^" + exposant);
        }

        public double eval(double x)
        {
            return Math.Pow(x, this.exposant);
        }

    }
}
