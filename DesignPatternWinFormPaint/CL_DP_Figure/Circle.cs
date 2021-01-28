using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_DP_Figure
{
    public class Circle : Figure
    {
        public Circle(int x, int y) : base(x, y)
        {
            //base.Draw();
        }
        public Circle(Point _point) : base(_point.x, _point.y)
        {
            //base.Draw();
        }

        public override void Draw()
        {
            // Code to create and draw a circle...
            Console.WriteLine($"Création d'un cercle aux coordonnées { x } et { y }");
        }
    }
}
