using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_DP_Figure
{
    public class Circle : Figure
    {
        private Point point;

        public double Radius
        {
            get; private set;
        }

        public Circle(int x, int y) : base(x, y)
        {
            //base.Draw();
            this.point = new Point(x, y);
            this.Radius = 1; // Default value
        }
        public Circle(Point _point) : base(_point.x, _point.y)
        {
            this.point = new Point(_point.x, _point.y);
            this.Radius = 1;  // Default value
            //base.Draw();
        }

        public Circle(Point _point, double _radius) : base(_point.x, _point.y)
        {
            this.point = new Point(_point.x, _point.y);
            this.Radius = _radius;
            //base.Draw();
        }

        public override void Draw()
        {
            // Code to create and draw a circle...
            Console.WriteLine($"Création d'un cercle aux coordonnées { this.point.x } et { this.point.y } avec un rayon de { this.Radius }");
        }
    }
}
