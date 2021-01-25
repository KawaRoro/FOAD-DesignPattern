using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_DesignPattern
{
    public class Nombre : Expression
    {
        private readonly double valeur;

        public Nombre(double _valeur)
        {
            this.valeur = _valeur;
        }

        public override double Evalue()
        {
            return valeur;
        }

        public override string Format()
        {
            return ToString();
        }

        public override string ToString()
        {
            return valeur.ToString();
        }

    }
}