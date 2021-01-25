using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_DesignPattern
{
    public abstract class Expression
    {
        protected Expression()
        {
        }

        public abstract double Evalue();
        public abstract string Format();
    }
}
