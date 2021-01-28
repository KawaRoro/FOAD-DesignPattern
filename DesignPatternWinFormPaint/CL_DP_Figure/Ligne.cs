using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_DP_Figure
{
    public class Ligne : Figure
    {
        //private Point point;

        public Ligne(int x, int y) : base(x, y)
        {
            //this.point = new Point(x, y);
        }
        public Ligne(Point _point) : base(_point.x, _point.y)
        {
            //this.point = new Point(_point.x, _point.y);
            //base.Draw();
        }

        public override void Draw()
        {
            // Code to create and draw a ligne...
            Console.WriteLine($"Création d'une ligne aux coordonnées { x } et { y }");
        }
    }
}