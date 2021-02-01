using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_DP_Figure
{
    public abstract class Figure
    {
        public Point pointFigure { get; set; }

        public Figure(int _x, int _y) // protected
        {
            pointFigure = new Point(_x, _y);
        }
        public Figure(Point _point) // protected
        {
            pointFigure = new Point(_point);
        }

        public bool MoveFigure(int _x, int _y)
        {
            if (pointFigure != null)
            {
                this.pointFigure.x = _x;
                this.pointFigure.y = _y;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool MoveFigure(Point _point)
        {
            if (pointFigure != null)
            {
                this.pointFigure.x = _point.x;
                this.pointFigure.y = _point.y;
                return true;
            }
            else
            {
                return false;
            }
        }

        public abstract void Draw();

        public abstract void AcceptVisitor(IVisitorForFigure visitor);
    }
}
