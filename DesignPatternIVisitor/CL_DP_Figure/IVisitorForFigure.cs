using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_DP_Figure
{
    public interface IVisitorForFigure
    {
        object Visitor { get; }

        void VisitorForFigure(Figures figures);
        void VisitorForFigure(Ligne ligne);
        void VisitorForFigure(Circle circle);
        void VisitorForFigure(Square square);
        void VisitorForFigure(Triangle triangle);
    }
}