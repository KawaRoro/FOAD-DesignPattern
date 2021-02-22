using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Iterator
{
    public class Enumerator
    {
        public Enumerator moveNext()
        {
            return this;
        }

        public bool hasNext()
        {
            return true;
        }
    }
}
