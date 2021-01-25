using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_DesignPattern
{
    public abstract class Binaire : Expression
    {
        protected Expression Nombre1 { get; }
        protected Expression Nombre2 { get; }

        protected Binaire(Expression _op1, Expression _op2)
        {
            this.Nombre1 = _op1;
            this.Nombre2 = _op2;
        }
        
    }
}