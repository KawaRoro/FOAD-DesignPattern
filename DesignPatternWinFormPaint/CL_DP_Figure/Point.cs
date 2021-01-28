using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_DP_Figure
{
    public class Point
    {
        public int x { get; set; } // protected // private 
        public int y { get; set; }

        public Point(int _x, int _y)
        {
            this.x = _x;
            this.y = _y;
        }

        public Point(Point _point)
        {
            this.x = _point.x;
            this.y = _point.y;
        }

        public override string ToString()
        {
            return this.x.ToString() + "," + this.y.ToString();
        }

    }
}
