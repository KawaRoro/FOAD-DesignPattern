using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_DP_Figure
{
    public abstract class Figure
    {
        public int x { get; set; } // protected // private 
        public int y { get; set; } // protected // private 
        //public int Height { get; set; }
        //public int Width { get; set; }

        public Figure(int _x, int _y) // protected
        {
            this.x = _x;
            this.y = _y;
        }

        public abstract void Draw();
        
    }
}
