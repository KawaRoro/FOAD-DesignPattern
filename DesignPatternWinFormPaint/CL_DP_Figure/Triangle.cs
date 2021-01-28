using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_DP_Figure
{
    public class Triangle : Figure
    {
        public Triangle(int x, int y) : base(x,y)
        {
            //base.Draw();
        }
        public Triangle(Point _point) : base(_point.x, _point.y)
        {
            //base.Draw();
        }

        public override void Draw()
        {
            // Code to create and draw a triangle...
            Console.WriteLine($"Création d'un triangle aux coordonnées { x } et { y }");
        }
    }
}
