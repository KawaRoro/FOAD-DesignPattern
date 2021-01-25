using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_DesignPattern
{
    public abstract class Binaire : Expression
    {
        protected Expression entier1;
        protected Expression entier2;
        protected Expression entier3;
        protected Binaire(Expression _op1, Expression _op2)
        {
            this.entier1 = _op1;
            this.entier2 = _op2;
        }
        protected Binaire(Expression _op1, Expression _op2, Expression _op3)
        {
            this.entier1 = _op1;
            this.entier2 = _op2;
            this.entier3 = _op3;
        }
    }
}