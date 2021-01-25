using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_DesignPattern
{
    public class Multiplication : Binaire
    {
        public Multiplication(Expression _op1, Expression _op2) : base(_op1, _op2)
        {
        }

        public Multiplication(Expression _op1, Expression _op2, Expression _op3) : base(_op1, _op2, _op3)
        {
        }

        public override double Evalue()
        {
            if (entier1 != null && entier2 != null && entier3 != null)
            {
                return entier1.Evalue() / entier2.Evalue() / entier3.Evalue();
            }
            else
            {
                return entier1.Evalue() / entier2.Evalue();
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

