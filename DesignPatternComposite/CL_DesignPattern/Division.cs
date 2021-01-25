/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_DesignPattern
{
    public class Division : Binaire
    {
        public Division(Expression _op1, Expression _op2) : base(_op1, _op2)
        {
        }

        public override double Evalue()
        {
            if (entier1 != null && entier2 != null)
            {
                return entier1.Evalue() / entier2.Evalue();
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}*/
