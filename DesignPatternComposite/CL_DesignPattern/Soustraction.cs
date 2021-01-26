using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_DesignPattern
{
    public class Soustraction : Binaire
    {
        public Soustraction(Expression _op1, Expression _op2) : base(_op1, _op2)
        {
        }

        public override double Evalue()
        {
            if (Nombre1 != null && Nombre2 != null)
            {
                return Nombre1.Evalue() - Nombre2.Evalue();
            }
            else
            {
                return 0;
            }
        }

        public override string FormatGauche()
        {
            return $"{ToString()} = " + this.Evalue().ToString();
        }

        public override string ToString()
        {
            return $"({Nombre1} + {Nombre2})";
        }
    }
}
