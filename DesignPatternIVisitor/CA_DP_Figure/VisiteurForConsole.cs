using CL_DP_Figure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_DP_Figure
{
    class VisiteurForConsole : IVisitorForFigure
    {
        public object Visitor { get; set; }

        public void VisitorForFigure(Figures figures)
        {
            throw new NotImplementedException();
        }

        public void VisitorForFigure(Ligne ligne)
        {
            throw new NotImplementedException();
        }

        public void VisitorForFigure(Circle circle)
        {
            throw new NotImplementedException();
        }

        public void VisitorForFigure(Square square)
        {
            throw new NotImplementedException();
        }

        public void VisitorForFigure(Triangle triangle)
        {
            throw new NotImplementedException();
        }
    }
}
