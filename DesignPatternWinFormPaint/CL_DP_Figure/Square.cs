using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_DP_Figure
{
    public class Square : Figure
    {
        public Square(int x, int y) : base(x, y)
        {
            //base.Draw();
        }
        public Square(Point _point) : base(_point.x, _point.y)
        {
            //base.Draw();
        }

        public override void Draw()
        {
            // Code to create and draw a rectangle...
            Console.WriteLine($"Création d'une rectangle aux coordonnées { x } et { y }");
        }
    }
}
