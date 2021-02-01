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
        //public int x { get; set; } // protected // private 
        //public int y { get; set; } // protected // private 
        //public int Height { get; set; }
        //public int Width { get; set; }

        public Figure(int _x, int _y) // protected
        {
            pointFigure = new Point(_x, _y);
        }
        public Figure(Point _point) // protected
        {
            pointFigure = new Point(_point);
        }

        public abstract void Draw();
        
    }
}
